using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Name: Jaydeep Lakhwani
* Date: July 13,2017
* Description: This is the SUperHero class which inherits from the SuperHUman class and implements the IHasKarma Interface
* Version: 0.1 - Created the SuperHero class
*/
namespace COMP123_S2017_lesson9B
{
	/// <summary>
	/// This is SuperHero class
	/// </summary>

	class SuperHero : SuperHuman, IHasKarma
	{
		// PRIVATE INSTANCE VARIABLES

		private int _karma;

		//PUBLIC PROPERTIES

			public int Karma
			{
				get
				{
				return this._karma;
				}
				set
				{
				this._karma = value;
				}
			}

		//CONSTRUCTOR
		/// <summary>
		/// This is the main constructor for the SuperHero class
		/// It takes a argument - name(string)
		/// </summary>
		/// <param name="name"></param>
		public SuperHero(string name)
			: base(name)
		{

		}
		//PRIVATE METHODS

		//PUBLIC METHODS
	}
}
