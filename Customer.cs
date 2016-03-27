using System;
using System.Net;
using System.Globalization;
using InterfaceCustomer;
using InterfaceDAL;

namespace MiddleLayer
{

	public class Customer : CustomerBase
	{
		public Customer()
		{
			CustomerType = "c";
		}
		public Customer(IValidation<ICustomer> obj) : base(obj)
		{
			CustomerType = "c";
		}
	}

	public class Lead : CustomerBase
	{
		public Lead()
		{
			CustomerType = "l";
		}
		public Lead(IValidation<ICustomer> obj) : base(obj)
		{
			CustomerType = "l";
		}
	}
}
