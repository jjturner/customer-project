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
		cust = Factory.Create (cboCustomerType.ActiveText); 
	}

	protected void cmdValidate_Clicked (object sender, EventArgs e)
	{
		cust.Validate ();
	}
}
