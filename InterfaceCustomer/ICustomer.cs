using System;

namespace InterfaceCustomer
{
	public interface ICustomer
	{
		string CustomerType { get; set; }
		string CustomerName { get; set; }
		string PhoneNumber { get; set; }
		decimal? BillAmount { get; set; }
		DateTime? BillDate { get; set; }
		string Address { get; set; }
		void Validate();
	}

	// Design pattern: Strategy Pattern 
	// (helps to select algorithms at run time, e.g. Tax calcs, Salary calcs, Validations, etc)
	public interface IValidation<AnyType>
	{
		void Validate(AnyType obj);
	}
}

