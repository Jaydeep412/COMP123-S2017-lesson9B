using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Name: Jaydeep Lakhwani
* Date: July 11,2017
* Description: This is the Abstract Human Class
* Version: 0.1 - Created the Abstract Human Class
*/
namespace COMP123_S2017_lesson9B
{

	/// <summary>
	/// This is Abstract Human Class
	/// </summary>
	public abstract class Human
	{
		// PRIVATE INSTANCE VARIABLES (FIELDS)
		private string _name;
	
		// PUBLIC PROPERTIES
		public string Name
		{
			get
			{

				return this._name;
			}
			set
			{
				this._name = value;
			}

		}

		/// <summary>
		/// This is the main constructor for the human class.
		/// It takes one parameter - name(string)
		/// </summary>
		/// <param name="name"></param>

		//CONSTRUCTOR ----------------------------------------------------------------
		public Human(string name)
		{
			this.Name = name;
		}


		//PRIVATE METHODS

		//PUBLIC METHODS
	}
}
