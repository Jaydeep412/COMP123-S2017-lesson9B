using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 11,2017
* Description: This is the SuperHuman Class that extends the Human Abstract class
* Version: 0.4 - Added overriden method ToString
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

		public List<Power> Powers
		{
			get
			{
				return this._powers; // this returns powers list
			}

		}

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
		public void AddPower(string name, int rank)
		{
			this.Powers.Add(new Power(name,rank));
		}

		public void DisplayPower()
		{
			foreach (Power power in this.Powers)
			{
				Console.WriteLine("Power:" + power.Name + "Rank:" + power.Rank);
			} 
		}

		/// <summary>
		/// Overridden the built-in ToString method
		/// </summary>
		/// <returns>
		/// string 
		/// </returns>
		public override string ToString()
		{
				string outputString = "";
				outputString += "================================\n";
				outputString += "SuperHuman Name:" + this.Name + "\n";
				outputString += "================================\n";

				foreach (Power power in this.Powers)
				{
					outputString+= "Power:" + power.Name + "Rank:" + power.Rank + "\n";
				}


				return outputString;
			
		}

	}
}
