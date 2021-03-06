﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterfaceCustomer;
using ValidationAlgorithms;
using MiddleLayer;
using InterfaceDAL;
using CommonDAL;
using Microsoft.Practices.Unity;


namespace FactoryCustomer
{
	public static class Factory<AnyType> // Design pattern: simple factory pattern
	{
		private static IUnityContainer project_objects = null;

		// Lazy step 1:
		// private static Lazy<Dictionary<string, CustomerBase>> _custs = null;

		// new Dictionary<string, CustomerBase> ();
		// private static Lazy<custs> custs = null;

		private static Dictionary<string, ICustomer> GetCustomerTypes ()
		{
			// Lazy step 3:
			// (implement assignments)
			Dictionary<string, ICustomer> cust_types = new Dictionary<string, ICustomer> ();

			// cust_types.Add ("Customer", new Customer ());
			// cust_types.Add ("Lead", new Lead ());
				
			return cust_types;
		}

		//static Factory ()
		//{
			// Design pattern: Lazy loading
			// Lazy step 2:
			// _custs = new Lazy<Dictionary<string, CustomerBase>> (() => GetCustomerTypes ());
		//}

		public static AnyType Create (string Type)
		{
			if (project_objects == null) {

				project_objects = new UnityContainer ();
				project_objects.RegisterType<CustomerBase, Customer> 
					("Customer", new InjectionConstructor (new CustomerValidationAll ()));
				project_objects.RegisterType<CustomerBase, Lead>
					("Lead", new InjectionConstructor (new LeadValidation ()));
			}
			// Design pattern: RIP pattern (Replace If with Polymorphism)

			// Lazy step 4:
			// retrieve Lazy object via Value property
			// return _custs.Value [TypeCust];

			// below connection string works in test_npgsql project
			return project_objects.Resolve<AnyType> (Type);
		}
	}
}