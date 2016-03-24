using System;
using System.Collections.Generic;
using InterfaceDAL;
using InterfaceCustomer;
using System.Linq;
using System.Data.Entity;

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

	public class EF_DalAbstract<AnyType> : DbContext, IDal<AnyType>
		where AnyType : class
	{
		public EF_DalAbstract ()
			: base("name=Conn")
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

	public class EF_CustomerDal : EF_DalAbstract<ICustomer>
	{
		// mapping
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CustomerBase> ()
				.ToTable ("customers");
		}
	}
}
