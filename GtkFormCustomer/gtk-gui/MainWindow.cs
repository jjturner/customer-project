
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.Table table1;
	
	private global::Gtk.ComboBox cboCustomerType;
	
	private global::Gtk.Entry entry1;
	
	private global::Gtk.Entry entry2;
	
	private global::Gtk.Entry entry3;
	
	private global::Gtk.Entry entry4;
	
	private global::Gtk.Entry entry5;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.Label label3;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.Label label5;
	
	private global::Gtk.Label label6;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Button button2;
	
	private global::Gtk.Fixed fixed1;
	
	private global::Gtk.Frame frame1;
	
	private global::Gtk.Alignment GtkAlignment;
	
	private global::Gtk.Label GtkLabel1;

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
		this.cboCustomerType = global::Gtk.ComboBox.NewText ();
		this.cboCustomerType.AppendText (global::Mono.Unix.Catalog.GetString ("Customer"));
		this.cboCustomerType.AppendText (global::Mono.Unix.Catalog.GetString ("Lead"));
		this.cboCustomerType.AppendText (global::Mono.Unix.Catalog.GetString ("Alien"));
		this.cboCustomerType.AppendText (global::Mono.Unix.Catalog.GetString ("Security Guard"));
		this.cboCustomerType.AppendText ("");
		this.cboCustomerType.Name = "cboCustomerType";
		this.cboCustomerType.Active = 0;
		this.table1.Add (this.cboCustomerType);
		global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.cboCustomerType]));
		w1.LeftAttach = ((uint)(1));
		w1.RightAttach = ((uint)(2));
		w1.XOptions = ((global::Gtk.AttachOptions)(4));
		w1.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.table1.Add (this.entry1);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry1]));
		w2.TopAttach = ((uint)(1));
		w2.BottomAttach = ((uint)(2));
		w2.LeftAttach = ((uint)(1));
		w2.RightAttach = ((uint)(2));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '●';
		this.table1.Add (this.entry2);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry2]));
		w3.TopAttach = ((uint)(2));
		w3.BottomAttach = ((uint)(3));
		w3.LeftAttach = ((uint)(1));
		w3.RightAttach = ((uint)(2));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.entry3 = new global::Gtk.Entry ();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '●';
		this.table1.Add (this.entry3);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry3]));
		w4.LeftAttach = ((uint)(3));
		w4.RightAttach = ((uint)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.entry4 = new global::Gtk.Entry ();
		this.entry4.CanFocus = true;
		this.entry4.Name = "entry4";
		this.entry4.IsEditable = true;
		this.entry4.InvisibleChar = '●';
		this.table1.Add (this.entry4);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry4]));
		w5.TopAttach = ((uint)(1));
		w5.BottomAttach = ((uint)(2));
		w5.LeftAttach = ((uint)(3));
		w5.RightAttach = ((uint)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.entry5 = new global::Gtk.Entry ();
		this.entry5.HeightRequest = 85;
		this.entry5.CanFocus = true;
		this.entry5.Name = "entry5";
		this.entry5.IsEditable = true;
		this.entry5.InvisibleChar = '●';
		this.table1.Add (this.entry5);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry5]));
		w6.TopAttach = ((uint)(2));
		w6.BottomAttach = ((uint)(3));
		w6.LeftAttach = ((uint)(3));
		w6.RightAttach = ((uint)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Customer Type");
		this.table1.Add (this.label1);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Customer Name");
		this.table1.Add (this.label2);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
		w8.TopAttach = ((uint)(1));
		w8.BottomAttach = ((uint)(2));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Phone Number");
		this.table1.Add (this.label3);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
		w9.TopAttach = ((uint)(2));
		w9.BottomAttach = ((uint)(3));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(0));
		// Container child table1.Gtk.Table+TableChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Bill Amount");
		this.table1.Add (this.label4);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
		w10.LeftAttach = ((uint)(2));
		w10.RightAttach = ((uint)(3));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Bill Date");
		this.table1.Add (this.label5);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
		w11.TopAttach = ((uint)(1));
		w11.BottomAttach = ((uint)(2));
		w11.LeftAttach = ((uint)(2));
		w11.RightAttach = ((uint)(3));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Address");
		this.table1.Add (this.label6);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
		w12.TopAttach = ((uint)(2));
		w12.BottomAttach = ((uint)(3));
		w12.LeftAttach = ((uint)(2));
		w12.RightAttach = ((uint)(3));
		w12.XOptions = ((global::Gtk.AttachOptions)(4));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox1.Add (this.table1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.table1]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
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
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.button2]));
		w14.Position = 0;
		w14.Expand = false;
		w14.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		this.hbox2.Add (this.fixed1);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fixed1]));
		w15.Position = 1;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		this.frame1.Add (this.GtkAlignment);
		this.GtkLabel1 = new global::Gtk.Label ();
		this.GtkLabel1.Name = "GtkLabel1";
		this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>GtkFrame</b>");
		this.GtkLabel1.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel1;
		this.vbox1.Add (this.frame1);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame1]));
		w18.Position = 2;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 723;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.cboCustomerType.Changed += new global::System.EventHandler (this.cboCustType_OnChange);
		this.button2.Clicked += new global::System.EventHandler (this.cmdValidate_Clicked);
	}
}