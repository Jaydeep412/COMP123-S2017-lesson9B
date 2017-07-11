using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 11,2017
* Description: This is the Power class
* Version: 0.2 - Created power constructor
*/

namespace COMP123_S2017_lesson9B
{
	/// <summary>
	/// This is the Power class which will be used as a Data type
	/// </summary>
	class Power
	{
		// PRIVATE INSTANCE VARIABLES

		public string Name { get; set; }

		public int Rank { get; set; }
		//PUBLIC PROPERTIES

		//CONSTRUCTOR
		/// <summary>
		/// This is the main consturctor for power class
		/// It takes two parameters - name(string) and rank (int)
		/// </summary>
		/// <param name="name"></param>
		/// <param name="rank"></param>


		public Power(string name, int rank)
		{
			this.Name = name;
			this.Rank = rank;
		}

		//PRIVATE METHODS

		//PUBLIC METHODS


	}
}
