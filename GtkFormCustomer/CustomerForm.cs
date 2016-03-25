using System;
using System.Collections.Generic;
using InterfaceCustomer;
using InterfaceDAL;
using FactoryCustomer;
using FactoryDAL;
using Npgsql;
using Gtk;
using GtkFormCustomer;

public partial class MainWindow: Gtk.Window
{

	private CustomerBase cust = null;
	private NodeStore store = null;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		// (Default is set via the "Active" property in Stetic)
		// cboDalType.S.HasDefault = "ADO.NET";

		// SetCustomer ();
		InitializeCustomerGrid();
		LoadCustomers ();
	}

	private void InitializeCustomerGrid()
	{
		// NodeView needs association to NodeStore in order to render headers
		store = new NodeStore (typeof(CustomerTreeNode)); 
		nodeview_customers.NodeStore = store;
		nodeview_customers.AppendColumn("Type", new CellRendererText(), "text", 0);
		nodeview_customers.AppendColumn("Cust", new CellRendererText(), "text", 1);
		nodeview_customers.AppendColumn("Phone", new CellRendererText(), "text", 2);
		nodeview_customers.AppendColumn("Address", new CellRendererText(), "text", 3);
		nodeview_customers.AppendColumn("Bill Dt", new CellRendererText(), "text", 4);
		nodeview_customers.AppendColumn("Bill Amt", new CellRendererText(), "text", 5);

		nodeview_customers.ShowAll ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void cboCustType_OnChange (object sender, EventArgs e)
	{
		cust = Factory<CustomerBase>.Create (cboCustomerType.ActiveText); 
	}

	private void SetCustomer ()
	{
		cust.CustomerType = cboCustomerType.ActiveText == "Lead" ? "l" : "c";
		cust.CustomerName = CustNameEntry.Text;
		cust.PhoneNumber = PhoneNumberEntry.Text;
		cust.BillAmount = Convert.ToDecimal (BillAmountEntry.Text);
		cust.BillDate = Convert.ToDateTime (BillDateEntry.Text);
		cust.Address = AddressEntry.Text;
	}

	private void LoadCustomers()
	{
		string dal_type = cboDalType.ActiveText == "ADO.NET" ? "ADODal" : "EF_Dal";
		IDal<CustomerBase> idal = FactoryDalLayer<IDal<CustomerBase>>.Create (dal_type);  
		List<CustomerBase> custs = idal.Select();

		foreach (CustomerBase customer in custs)
		{
			AddCustomerNode (customer);
		}
	}

	private void AddCustomerNode(CustomerBase cust_to_add)
	{
		CustomerTreeNode cust_treenode = new CustomerTreeNode ();
		cust_treenode.CustomerName = cust_to_add.CustomerName;
		cust_treenode.CustomerType = cust_to_add.CustomerType;
		cust_treenode.PhoneNumber = cust_to_add.PhoneNumber;
		cust_treenode.Address = cust_to_add.Address;
		cust_treenode.BillDate = cust_to_add.BillDate.ToString();
		cust_treenode.BillAmount = cust_to_add.BillAmount.ToString();

		store.AddNode(cust_treenode);
	}

	protected void cmdValidate_Clicked (object sender, EventArgs e)
	{
		try {
			SetCustomer ();
			cust.Validate ();
		} catch (Exception ex) {
			MessageDialog msg = new MessageDialog(
				this
				,DialogFlags.Modal
				,MessageType.Error
				,ButtonsType.Ok
				,ex.Message.ToString ());
			msg.Run ();
			msg.Destroy ();
		}
	}

	protected void cmdAdd_Clicked (object sender, EventArgs e)
	{
		SetCustomer ();
		// took awhile to realize 'Factory' needed to be re-referenced as 'FactoryDalLayer'
		IDal<CustomerBase> dal = FactoryDalLayer<IDal<CustomerBase>>.Create ("ADODal");
		dal.Add (cust);
		dal.Save ();
		AddCustomerNode (cust);
		// TODO: test if ShowAll is necessary after adding node
		nodeview_customers.ShowAll ();
	}

	protected void SwitchDAL (object sender, EventArgs e)
	{
		store.Clear ();
		LoadCustomers ();
		nodeview_customers.ShowAll ();
	}
}
