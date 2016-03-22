
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.Table table1;
	
	private global::Gtk.Entry AddressEntry;
	
	private global::Gtk.Entry BillAmountEntry;
	
	private global::Gtk.Entry BillDateEntry;
	
	private global::Gtk.ComboBox cboCustomerType;
	
	private global::Gtk.Entry CustNameEntry;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.Label label3;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.Label label5;
	
	private global::Gtk.Label label6;
	
	private global::Gtk.Entry PhoneNumberEntry;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Button button2;
	
	private global::Gtk.Fixed fixed1;
	
	private global::Gtk.Button button1;
	
	private global::Gtk.Frame frame1;
	
	private global::Gtk.Label GtkLabel2;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.NodeView nodeview_customers;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table (((uint)(3)), ((uint)(4)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.AddressEntry = new global::Gtk.Entry ();
		this.AddressEntry.HeightRequest = 85;
		this.AddressEntry.CanFocus = true;
		this.AddressEntry.Name = "AddressEntry";
		this.AddressEntry.IsEditable = true;
		this.AddressEntry.InvisibleChar = '●';
		this.table1.Add (this.AddressEntry);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.AddressEntry]));
		w1.TopAttach = ((uint)(2));
		w1.BottomAttach = ((uint)(3));
		w1.LeftAttach = ((uint)(3));
		w1.RightAttach = ((uint)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.BillAmountEntry = new global::Gtk.Entry ();
		this.BillAmountEntry.CanFocus = true;
		this.BillAmountEntry.Name = "BillAmountEntry";
		this.BillAmountEntry.IsEditable = true;
		this.BillAmountEntry.InvisibleChar = '●';
		this.table1.Add (this.BillAmountEntry);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.BillAmountEntry]));
		w2.LeftAttach = ((uint)(3));
		w2.RightAttach = ((uint)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.BillDateEntry = new global::Gtk.Entry ();
		this.BillDateEntry.CanFocus = true;
		this.BillDateEntry.Name = "BillDateEntry";
		this.BillDateEntry.IsEditable = true;
		this.BillDateEntry.InvisibleChar = '●';
		this.table1.Add (this.BillDateEntry);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.BillDateEntry]));
		w3.TopAttach = ((uint)(1));
		w3.BottomAttach = ((uint)(2));
		w3.LeftAttach = ((uint)(3));
		w3.RightAttach = ((uint)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.cboCustomerType = global::Gtk.ComboBox.NewText ();
		this.cboCustomerType.AppendText (global::Mono.Unix.Catalog.GetString ("Customer"));
		this.cboCustomerType.AppendText (global::Mono.Unix.Catalog.GetString ("Lead"));
		this.cboCustomerType.Name = "cboCustomerType";
		this.cboCustomerType.Active = 0;
		this.table1.Add (this.cboCustomerType);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.cboCustomerType]));
		w4.LeftAttach = ((uint)(1));
		w4.RightAttach = ((uint)(2));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.CustNameEntry = new global::Gtk.Entry ();
		this.CustNameEntry.CanFocus = true;
		this.CustNameEntry.Name = "CustNameEntry";
		this.CustNameEntry.IsEditable = true;
		this.CustNameEntry.InvisibleChar = '●';
		this.table1.Add (this.CustNameEntry);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.CustNameEntry]));
		w5.TopAttach = ((uint)(1));
		w5.BottomAttach = ((uint)(2));
		w5.LeftAttach = ((uint)(1));
		w5.RightAttach = ((uint)(2));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Customer Type");
		this.table1.Add (this.label1);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Customer Name");
		this.table1.Add (this.label2);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
		w7.TopAttach = ((uint)(1));
		w7.BottomAttach = ((uint)(2));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.Xalign = 0F;
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Phone Number");
		this.table1.Add (this.label3);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
		w8.TopAttach = ((uint)(2));
		w8.BottomAttach = ((uint)(3));
		w8.RightAttach = ((uint)(2));
		w8.YPadding = ((uint)(28));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Bill Amount");
		this.table1.Add (this.label4);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
		w9.LeftAttach = ((uint)(2));
		w9.RightAttach = ((uint)(3));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Bill Date");
		this.table1.Add (this.label5);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
		w10.TopAttach = ((uint)(1));
		w10.BottomAttach = ((uint)(2));
		w10.LeftAttach = ((uint)(2));
		w10.RightAttach = ((uint)(3));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.Yalign = 0.07F;
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Address");
		this.table1.Add (this.label6);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
		w11.TopAttach = ((uint)(2));
		w11.BottomAttach = ((uint)(3));
		w11.LeftAttach = ((uint)(2));
		w11.RightAttach = ((uint)(3));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.PhoneNumberEntry = new global::Gtk.Entry ();
		this.PhoneNumberEntry.CanFocus = true;
		this.PhoneNumberEntry.Name = "PhoneNumberEntry";
		this.PhoneNumberEntry.IsEditable = true;
		this.PhoneNumberEntry.InvisibleChar = '●';
		this.table1.Add (this.PhoneNumberEntry);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.PhoneNumberEntry]));
		w12.TopAttach = ((uint)(2));
		w12.BottomAttach = ((uint)(3));
		w12.LeftAttach = ((uint)(1));
		w12.RightAttach = ((uint)(2));
		w12.XOptions = ((global::Gtk.AttachOptions)(4));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox1.Add (this.table1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w14.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button ();
		this.button2.WidthRequest = 180;
		this.button2.HeightRequest = 37;
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.BorderWidth = ((uint)(3));
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("Validate");
		this.hbox2.Add (this.button2);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.button2]));
		w15.Position = 0;
		w15.Expand = false;
		w15.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button ();
		this.button1.WidthRequest = 180;
		this.button1.HeightRequest = 37;
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.BorderWidth = ((uint)(3));
		this.button1.Label = global::Mono.Unix.Catalog.GetString ("Add Customer");
		this.fixed1.Add (this.button1);
		this.hbox2.Add (this.fixed1);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fixed1]));
		w17.Position = 1;
		w17.Expand = false;
		w17.Fill = false;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w18.Position = 3;
		w18.Expand = false;
		w18.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		this.GtkLabel2 = new global::Gtk.Label ();
		this.GtkLabel2.Name = "GtkLabel2";
		this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>GtkFrame</b>");
		this.GtkLabel2.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel2;
		this.vbox1.Add (this.frame1);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame1]));
		w19.Position = 4;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.nodeview_customers = new global::Gtk.NodeView ();
		this.nodeview_customers.CanFocus = true;
		this.nodeview_customers.Name = "nodeview_customers";
		this.GtkScrolledWindow.Add (this.nodeview_customers);
		this.vbox1.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
		w21.Position = 5;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 723;
		this.DefaultHeight = 393;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.cboCustomerType.Changed += new global::System.EventHandler (this.cboCustType_OnChange);
	}
}
