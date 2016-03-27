using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Npgsql;

namespace InterfaceCustomer
{
	public interface ICustomer
	{
		int CustID { get; set; }
		string CustomerType { get; set; }
		string CustomerName { get; set; }
		string PhoneNumber { get; set; }
		decimal? BillAmount { get; set; }
		DateTime? BillDate { get; set; }
		string Address { get; set; }
		void Validate();
	}

	[Table ("customers", Schema = "public")]
	public class CustomerBase : ICustomer
	{
		private IValidation<ICustomer> validation = null;
		public CustomerBase(IValidation<ICustomer> obj)
		{
			validation = obj;	
		}
		[Key]
		[Column("cust_id")]
		public int CustID { get; set; }
		[Column("customer_type")]
		public string CustomerType { get; set; }
		[Column("customer_name")]
		public string CustomerName { get; set; }
		[Column("phone_number")]
		public string PhoneNumber { get; set; }
		[Column("bill_amount")]
		public decimal? BillAmount { get; set; }
		[Column("bill_date")]
		public DateTime? BillDate { get; set; }
		[Column("address")]
		public string Address { get; set; }

		public CustomerBase ()
		{
			CustomerType = "";
			CustomerName = "";
			PhoneNumber = "";
			BillAmount = 0;
			BillDate = DateTime.Now;
			Address = "";
		}
		public virtual void Validate ()
		{
			validation.Validate (this);
		}
	}

	// Design pattern: Strategy Pattern 
	// (helps to select algorithms at run time, e.g. Tax calcs, Salary calcs, Validations, etc)
	public interface IValidation<AnyType>
	{
		void Validate(AnyType obj);
	}
}

