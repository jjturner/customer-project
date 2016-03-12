using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using MiddleLayer;
using Gtk;

namespace GtkFormCustomer
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			//Window win_gtk = new Window ("foo");
			//win_gtk.Resize (200, 200);
			Label testLabel = new Label ();
			testLabel.Text = "Hello World!";
			//win_gtk.Add (testLabel);
			//win_gtk.ShowAll ();
			win.Show();
			Application.Run ();
		}
	}
}