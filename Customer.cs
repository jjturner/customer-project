using System;
using System.Net;
using System.Globalization;
using InterfaceCustomer;

namespace MiddleLayer
{
	public class CustomerBase : ICustomer
	{
		public string CustomerName { get; set; }
		public string PhoneNumber { get; set; }
		public decimal BillAmount { get; set; }
		public DateTime BillDate { get; set; }
		public string Address { get; set; }

		public virtual void Validate ()
		{
			throw new Exception ("Not implemented");
		}
	}

	public class Customer : CustomerBase
	{
	}

	public class Lead : CustomerBase
	{
	}
}
