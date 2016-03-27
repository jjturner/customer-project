using System;
using System.Collections.Generic;
using InterfaceDAL;
using InterfaceCustomer;
using Npgsql;
using System.Linq;
using MiddleLayer;
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
				Database=customer;
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
//			List<AnyType> dataset = Set<AnyType> ()
//				.AsQueryable<AnyType> ()
//				.ToList ();
//
//			CustomerBase datarow = (CustomerBase)dataset.First();
//
//			Console.WriteLine (datarow["CustomerName"].ToString());

			return Set<AnyType> ()
				.AsQueryable<AnyType> ()
				.ToList ();
		}

		public void Save()
		{
			SaveChanges (); // effects physical commit of pending DML changes
		}
	}

	/// <summary>
	/// Subclasses require explicit mapping to entities
	/// via the property(ies) which distinguish the subclass values
	/// even when base class is concrete
	/// in the case when the relevant properties differ from
	/// the corresponding column names
	/// (online example only required this mapping when
	///  used with abstract class since there was no diff betw
	///  property names and column names) 
	/// </summary> 
	public class EF_CustomerDal : EF_DalAbstract<CustomerBase>
	{
		// map table to class name
        public DbSet<CustomerBase> customers { get; set; }

		// mapping
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
// 	  	(below commented line is equivalent to DbSet mapping above)
//			modelBuilder.Entity<CustomerBase> ()
//				.ToTable ("customers");
			modelBuilder.Entity<CustomerBase> ()
				.Map<Customer> (m => m.Requires ("customer_type").HasValue ("c"))
				.Map<Lead> (m => m.Requires ("customer_type").HasValue ("l"));
			modelBuilder.Entity<CustomerBase> ()
				.Ignore (t => t.CustomerType);
		}

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
				Database=customer;
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