using System;
using Gtk;

namespace GtkFormCustomer
{
	[Gtk.TreeNode(ListOnly=true)]
	public class CustomerTreeNode : TreeNode
	{
		public CustomerTreeNode ()
		{
		}

		[TreeNodeValue(Column=0)]
		public string CustomerType { get; set; }

		[TreeNodeValue(Column=1)]
		public string CustomerName { get; set; }

		[TreeNodeValue(Column=2)]
		public string PhoneNumber { get; set; }

		[TreeNodeValue(Column=3)]
		public string Address { get; set; }
	
		[TreeNodeValue(Column=4)]
		public string BillDate { get; set; }

		[TreeNodeValue(Column=5)]
		public string BillAmount { get; set; }
	}

	//	CustomerTreeNode ctn = new CustomerTreeNode();
	[Gtk.TreeNode(ListOnly=true)]
	public class TestTreeNode : TreeNode
	{
		[TreeNodeValue(Column=0)]
		public string TestColumn { get; set; }
	}
}
