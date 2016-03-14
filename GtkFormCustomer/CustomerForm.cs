using System;
using InterfaceCustomer;
using FactoryCustomer;
using Gtk;

public partial class MainWindow: Gtk.Window
{

	private ICustomer cust = null;

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

	private void SetCustomer ()
	{
		cust.CustomerName = CustNameEntry.Text;
		cust.PhoneNumber = PhoneNumberEntry.Text;
		cust.BillAmount = Convert.ToDecimal (BillAmountEntry.Text);
		cust.BillDate = Convert.ToDateTime (BillDateEntry.Text);
		cust.Address = AddressEntry.Text;
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
}
