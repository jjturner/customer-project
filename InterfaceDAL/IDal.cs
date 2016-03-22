using System;
using System.Collections.Generic;

namespace InterfaceDAL
{
	// Design pattern: Generic Repository Pattern
	public interface IDal<AnyType>
	{
		void Add(AnyType obj);  	// in-memory insert
		void Update(AnyType obj);	// in-memory update
		// online example uses "Search", I opted for "Select"
		// --> need to ensure this gets propagated correctly in the class hierarchy
		List<AnyType> Select();
		void Save();  				// physical commit
	}
}

