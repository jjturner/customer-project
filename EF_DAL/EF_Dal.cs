using System;
using System.Collections.Generic;
using InterfaceDAL;
using InterfaceCustomer;
using Npgsql;
using System.Linq;

using System.Data;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_DAL
{
	/// <summary>
	///	
	/// Design pattern: Adapter Pattern ('class wrapping')
	/// 
	/// This is a means to achieve standardization between semantically incompatible,
	/// yet functionally equivalent classes.
	/// 
	/// In this case we implement the 'Inheritance' form of the Adapter Pattern 
	/// which is appropriate when standardizing 2 linguistically common classes,
	/// whereas the 'Object' form is appropriate for cases in which inheritance is not possible.
	/// 
	/// </summary>

	[DbConfigurationType (typeof(NpgsqlConfiguration))]
	public class EF_DalAbstract<AnyType> : DbContext, IDal<AnyType>
		where AnyType : class
	{
		static string conn_str =
			@"Server=localhost;
				User ID=postgres;
				Password=postgres;
				Database=customers;
				syncnotification=false;
				port=5432";
		
		public EF_DalAbstract ()
			: base(new NpgsqlConnection (conn_str), true)
		{
		}

		public void Add(AnyType obj)
		{
			// note 'where' clause in class signature -
			// this is necessary in order to typecast AnyType according to EF Method
			Set<AnyType>().Add (obj);
		}

		public void Update(AnyType obj)
		{
			throw new NotImplementedException();
		}

		public List<AnyType> Select()
		{
			return Set<AnyType> ()
				.AsQueryable<AnyType> ()
				.ToList ();
		}

		public void Save()
		{
			SaveChanges (); // effects physical commit of pending DML changes
		}
	}

	public class EF_CustomerDal : EF_DalAbstract<CustomerBase>
	{
		// mapping
//		protected override void OnModelCreating(DbModelBuilder modelBuilder)
//		{
//			modelBuilder.Entity<CustomerBase> ()
//				.ToTable ("customers");
//		}

		// now ref table to class name
        public DbSet<CustomerBase> customers { get; set; }
	}

	class NpgsqlConfiguration : DbConfiguration
	{
		public NpgsqlConfiguration ()
		{
			SetProviderServices("Npgsql", Npgsql.NpgsqlServices.Instance);
			SetProviderFactory("Npgsql", Npgsql.NpgsqlFactory.Instance);
			SetDefaultConnectionFactory(new Npgsql.NpgsqlConnectionFactory());
		}
	}

	[DbConfigurationType (typeof(NpgsqlConfiguration))]
    public class npgsql_tests_db : DbContext
    {
        static string conn_str =
			@"Server=localhost;
				User ID=postgres;
				Password=postgres;
				Database=customers;
				syncnotification=false;
				port=5432";

        public npgsql_tests_db ()
            : base (new NpgsqlConnection (conn_str), true)
        {

        }
		// now ref table to class name
        public DbSet<CustomerBase> customers { get; set; }
    }

	// refer to ICustomer namespace for implementation of CustomerBase
}