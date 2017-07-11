using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 11,2017
* Description: Demo for lesson 9
* Version: 0.4 - Added  another power to the Superhuman object
*			   - Also displayed all the powers in the Power List
*/
namespace COMP123_S2017_lesson9B
{
	class Program
	{
		static void Main(string[] args)
		{

			SuperHuman superHuman = new SuperHuman("Super Dude");

			superHuman.AddPower("Spider Climbing",50);
			superHuman.AddPower("Web casting", 40);
			superHuman.DisplayPower();


			// PRIVATE INSTANCE VARIABLES

			//PUBLIC PROPERTIES

			//CONSTRUCTOR

			//PRIVATE METHODS

			//PUBLIC METHODS
		}
	}
}

	