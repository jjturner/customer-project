using System;
using MiddleLayer;
using FactoryCustomer;
using Gtk;

public partial class MainWindow: Gtk.Window
{

	private CustomerBase cust = null;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void cboCustType_OnChange (object sender, EventArgs e)
	{
		cust = FactoryCustomer.Factory.Create (cboCustomerType.ActiveText); 
	}

	private void SetCustomer()
	{
		cust.CustomerName = CustNameEntry.Text;
		cust.PhoneNumber = PhoneNumberEntry.Text;
		cust.BillAmount = Convert.ToDecimal(BillAmountEntry.Text);
		cust.BillDate = Convert.ToDateTime(BillDateEntry.Text);
		cust.Address = AddressEntry.Text;
	}

	protected void cmdValidate_Clicked (object sender, EventArgs e)
	{
		SetCustomer ();
		cust.Validate ();
	}
}
