using System;
using System.Net;
using System.Globalization;
using InterfaceCustomer;
using InterfaceDAL;

namespace MiddleLayer
{

	public class Customer : CustomerBase
	{
		public Customer(IValidation<ICustomer> obj) : base(obj)
		{
		}
	}

	public class Lead : CustomerBase
	{
		public Lead(IValidation<ICustomer> obj) : base(obj)
		{
		}
	}
}
