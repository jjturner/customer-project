using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MiddleLayer;

namespace FactoryCustomer
{
	public static class Factory // Design pattern: simple factory pattern
	{
		private static Dictionary<string, CustomerBase> custs = 
			new Dictionary<string, CustomerBase> ();
		
		static Factory ()
		{
		}

		public static CustomerBase Create(string TypeCust)
		{
			// Design pattern: Lazy loading
			if (custs.Count == 0) {
				custs.Add ("Customer", new Customer ());
				custs.Add ("Lead", new Lead ());
			}
			// Design pattern: RIP pattern (Replace If with Polymorphism)
			return custs [TypeCust];
		}
	}
}

