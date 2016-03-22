using System;
using System.Collections.Generic;
using InterfaceDAL;

// all common DAL features go here
namespace CommonDAL
{
	public abstract class AbstractDal<AnyType> : IDal<AnyType>
	{
		protected string connection_string = "";

		public AbstractDal (string _connection_string)
		{
			connection_string = _connection_string;	
		}

		protected List<AnyType> AnyTypes = new List<AnyType>();

		// virtual gives opportunity to -override- the method
		public virtual void Add(AnyType obj)
		{
			AnyTypes.Add(obj);
		}

		public virtual void Update(AnyType obj)
		{
			throw new NotImplementedException();
		}

		public virtual List<AnyType> Select()
		{
			throw new NotImplementedException();
		}

		public virtual void Save()
		{
			throw new NotImplementedException ();
		}
	}
}

