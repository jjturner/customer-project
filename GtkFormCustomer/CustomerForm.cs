using System;
using System.Collections.Generic;
using InterfaceCustomer;
using InterfaceDAL;
using FactoryCustomer;
using FactoryDAL;
using Gtk;
using GtkFormCustomer;

public partial class MainWindow: Gtk.Window
{

	private ICustomer cust = null;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		// SetCustomer ();
		LoadCustomers ();

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void cboCustType_OnChange (object sender, EventArgs e)
	{
		cust = Factory<ICustomer>.Create (cboCustomerType.ActiveText); 
	}

	private void SetCustomer ()
	{
		cust.CustomerName = CustNameEntry.Text;
		cust.PhoneNumber = PhoneNumberEntry.Text;
		cust.BillAmount = Convert.ToDecimal (BillAmountEntry.Text);
		cust.BillDate = Convert.ToDateTime (BillDateEntry.Text);
		cust.Address = AddressEntry.Text;
	}

	private void LoadCustomers()
	{
		IDal<ICustomer> idal = FactoryDalLayer<IDal<ICustomer>>.Create ("ADODal");  
		List<ICustomer> custs = idal.Select();


		NodeStore store = new NodeStore (typeof(TestTreeNode)); 
		foreach (ICustomer cust in custs)
		{
			TestTreeNode cust_treenode = new TestTreeNode ();
			cust_treenode.TestColumn = "Krudler!";
			// cust_treenode.CustomerType = cust
			store.AddNode(cust_treenode);
		}

		nodeview_customers.NodeStore = store;
		// NodeView cust_nv = nodeview_customers;
		nodeview_customers.AppendColumn("Farley", new CellRendererText(), "text", 0);
		nodeview_customers.ShowAll ();
		// cust_nv.AppendColumn("Customer Type", new CellRendererText(), "text", 0);
		// cust_nv.AppendColumn("Customer Name", new CellRendererText(), "text", 1);

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
		IDal<ICustomer> dal = Factory<IDal<ICustomer>>.Create ("ADODal");
		dal.Add (cust);
		dal.Save ();
	}
}
