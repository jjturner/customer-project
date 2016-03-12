using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MiddleLayer;

namespace FactoryCustomer
{
	public static class Factory
	{
		//private static Dictionary<string, CustomerBase> custs = 
		//	new Dictionary<string, CustomerBase> ();
		
		public Factory ()
		{
		//	custs.Add ("Customer", new Customer ());
		//	custs.Add ("Lead", new Lead ());
		}

		public static CustomerBase Create(string TypeCust)
		{
			if (TypeCust == "Customer") {
				return = new Customer ();
			} else {
				return = new Lead ();
			}
		}
	}
}

