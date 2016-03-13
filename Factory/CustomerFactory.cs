using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MiddleLayer;

namespace FactoryCustomer
{
	public static class Factory // Design pattern: simple factory pattern
	{
		private static Lazy<Dictionary<string, CustomerBase>> _custs = null;
		// new Dictionary<string, CustomerBase> ();
		// private static Lazy<custs> custs = null;

		private static Dictionary<string, CustomerBase> GetCustomerTypes ()
		{
			Dictionary<string, CustomerBase> cust_types = new Dictionary<string, CustomerBase> ();
			cust_types.Add ("Customer", new Customer ());
			cust_types.Add ("Lead", new Lead ());
				
			return cust_types;
		}

		static Factory ()
		{
			// Design pattern: Lazy loading
			_custs = new Lazy<Dictionary<string, CustomerBase>> (() => GetCustomerTypes ());
		}

		public static CustomerBase Create (string TypeCust)
		{
			// Design pattern: RIP pattern (Replace If with Polymorphism)
			return _custs.Value [TypeCust];
		}
	}
}

