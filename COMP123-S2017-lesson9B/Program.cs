using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 11,2017
* Description: Demo for lesson 9
* Version: 0.5 - Used the ToString method of the SuperHuman class
*/
namespace COMP123_S2017_lesson9B
{
	class Program
	{
		static void Main(string[] args)
		{
			SuperHuman superHuman = new SuperHuman("Super Dude");

			superHuman.Powers.Add(new Power("Teleportation",50));
			superHuman.Powers.Add(new Power("Phasing", 40));
			superHuman.Powers.Add(new Power("Invisibility", 30));

			Console.Write(superHuman.ToString());

			// PRIVATE INSTANCE VARIABLES

			//PUBLIC PROPERTIES

			//CONSTRUCTOR

			//PRIVATE METHODS

			//PUBLIC METHODS
		}
	}
}

	