using System;
using CommonDAL;
using InterfaceDAL;
using InterfaceCustomer;
using System.Data;
using Npgsql;
using System.Data.SqlClient;


namespace ADODotNetDAL
{
	public abstract class TemplateADO<AnyType> : AbstractDal<AnyType>
	{
		protected NpgsqlConnection objConn = null;
		protected NpgsqlCommand objCommand = null;

		public TemplateADO (string _connection_string) : base(_connection_string)
		{
			
		}

		private void Open()
		{
			try {
				objConn = new NpgsqlConnection  (connection_string);
				objConn.Open ();
				objCommand = new NpgsqlCommand ();
				objCommand.Connection = objConn;	
			} catch (Exception ex) {
				Console.WriteLine ("error is: " + ex.Message + " -- " + ex.Data);
			}

		}
		protected abstract void ExecuteCommand (AnyType obj); // will be imp in Child classes

		private void Close()
		{
			objConn.Close ();
		}
		// Desing pattern: Template Pattern
		public void Execute(AnyType obj) // Fixed sequence
		{
			Open ();
			ExecuteCommand (obj);
			Close ();
		}
		public override void Save ()
		{
			foreach (AnyType o in AnyTypes) {
				Execute (o);
			}
		}
	}

	public class CustomerDal : TemplateADO<ICustomer>
	{
		public CustomerDal (string _connection_string) :
			base(_connection_string)
		{
				
		}
		protected override void ExecuteCommand (ICustomer obj)
		{
			objCommand.CommandText = $@"insert into customers(
				customer_name
				, bill_amount 
				, bill_date
				, phone_number
				, address)
				 values 
				('{obj.CustomerName}',{obj.BillAmount},'{obj.BillDate}','{obj.PhoneNumber}','{obj.Address}')"
				;
			objCommand.ExecuteNonQuery();
		}
	}
}