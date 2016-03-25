using System;
using System.Collections.Generic;
using CommonDAL;
using InterfaceDAL;
using InterfaceCustomer;
using System.Data;
using Npgsql;
using System.Data.SqlClient;
using FactoryCustomer;

// this code module is ADO-specific (Common/AbstractDAL applies to -any- DAL technology)
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
		protected abstract List<AnyType> ExecuteCommand();

		private void Close()
		{
			objConn.Close ();
		}
		// Desing pattern: Template Pattern
		public void Execute(AnyType obj) // Fixed sequence Insert
		{
			Open ();
			ExecuteCommand (obj);
			Close ();
		}
		public List<AnyType> Execute() // Fixed sequence Select
		{
			List<AnyType> objTypes = null;

			Open ();
			objTypes = ExecuteCommand ();
			Close ();
			return objTypes;
		}
		public override void Save ()
		{
			foreach (AnyType o in AnyTypes) {
				Execute (o);
			}
		}
		public override List<AnyType> Select()
		{
			return Execute ();
		}
	}

	public class CustomerDal : TemplateADO<CustomerBase>, IDal<CustomerBase>
	{
		public CustomerDal (string _connection_string) :
			base(_connection_string)
		{
				
		}

		protected override List<CustomerBase> ExecuteCommand()
		{
			objCommand.CommandText = "select * from customers";
			NpgsqlDataReader pg_reader = null;
			pg_reader = objCommand.ExecuteReader ();
			List<CustomerBase> custs = new List<CustomerBase> ();
			while (pg_reader.Read())
			{
				CustomerBase cust = Factory<CustomerBase>.Create ("Customer");

				cust.CustomerType = "c";
				cust.CustomerName = pg_reader ["customer_name"].ToString();
				cust.PhoneNumber = pg_reader ["phone_number"].ToString();
				cust.Address = pg_reader ["address"].ToString();
				cust.BillDate = Convert.ToDateTime ("3/22/2016"); 
				//Convert.ToDateTime((pg_reader["bill_date"] == null) ? 
					// "1/1/1900" : pg_reader ["bill_date"]);
				// cust.BillDate = pg_reader ["bill_date"].ToString();
				cust.BillAmount = 54203; // Convert.ToDecimal (pg_reader ["bill_amount"]);
				// cust.BillAmount = pg_reader ["bill_amount"].ToString();
				custs.Add (cust);
			}
			return custs;
		}

		protected override void ExecuteCommand (CustomerBase obj)
		{
			objCommand.CommandText = $@"insert into customers(
				customer_type
				, customer_name
				, bill_amount 
				, bill_date
				, phone_number
				, address)
				 values 
				(
					'{obj.CustomerType}'
					, '{obj.CustomerName}'
					, {obj.BillAmount}
					, '{obj.BillDate}'
					, '{obj.PhoneNumber}'
					, '{obj.Address}'
				)";
			objCommand.ExecuteNonQuery();
		}
	}
}