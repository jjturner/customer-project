using System;
using System.ComponentModel.DataAnnotations;

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

	public abstract class CustomerBase : ICustomer
	{
		private IValidation<ICustomer> validation = null;
		public CustomerBase(IValidation<ICustomer> obj)
		{
			validation = obj;	
		}
		[Key]
		public int CustID { get; set; }
		public string CustomerType { get; set; }
		public string CustomerName { get; set; }
		public string PhoneNumber { get; set; }
		public decimal? BillAmount { get; set; }
		public DateTime? BillDate { get; set; }
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

