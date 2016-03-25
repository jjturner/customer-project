using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterfaceCustomer;
using ValidationAlgorithms;
using MiddleLayer;
using CommonDAL;
using InterfaceDAL;
using ADODotNetDAL;
using EF_DAL;
using Microsoft.Practices.Unity;
using System.Data.Entity;
using Npgsql;

namespace FactoryDAL
{
	public static class FactoryDalLayer<AnyType> // Design pattern: simple factory pattern
	{
		private static IUnityContainer project_objects = null;

		public static AnyType Create (string Type)
		{
			if (project_objects == null) {

				project_objects = new UnityContainer ();
				project_objects.RegisterType<IDal<CustomerBase>, CustomerDal>
					("ADODal");
				project_objects.RegisterType<IDal<CustomerBase>, EF_CustomerDal>
					("EF_Dal");
			}

			// below connection string works in test_npgsql project
			return project_objects.Resolve<AnyType> (Type,
				new ResolverOverride[]
				{
					new ParameterOverride("_connection_string",
						"Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=customer")
				});
		}
	}
}
