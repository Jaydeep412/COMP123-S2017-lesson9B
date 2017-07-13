using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
* Name: Jaydeep Lakhwani
* Date: July 13,2017
* Description: This is an Interface that defines a Karma Property that
* must be implemented in any class that subscribes to it.
* Version: 0.1 - Created IHasKarma interface
*/

namespace COMP123_S2017_lesson9B
{

	/// <summary>
	/// This is IHasKarma interface
	/// </summary>
	interface IHasKarma
	{
		// PUBLIC PROPERIES
		int Karma { get; set; }
	}
}
