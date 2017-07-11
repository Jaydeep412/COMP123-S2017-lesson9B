using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 11,2017
* Description: This is the SuperHuman Class that extends the Human Abstract class
* Version: 0.2 - Added _initialize method
*/

namespace COMP123_S2017_lesson9B
{

	/// <summary>
	/// This is the SuperHuman Class.
	/// </summary>
	class SuperHuman : Human
	{
		// PRIVATE INSTANCE VARIABLES
		private List<Power> _powers;

		//PUBLIC PROPERTIES

		//CONSTRUCTOR
		/// <summary>
		/// This is the main constructor for the Super Human Class
		/// It takes one parameter - name(string)
		/// </summary>
		/// <param name="name"></param>

		public SuperHuman(string name)
			:base(name)
		{
			this._initialize();
		}

		//PRIVATE METHODS
		/// <summary>
		/// This metod instializaes, instantiates and assigns value to class propertiy power class
		/// </summary>
		private void _initialize()
		{
			this._powers = new List<Power>(); // creates an empty list
		}

		//PUBLIC METHODS
	}
}
