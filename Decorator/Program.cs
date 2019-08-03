using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			Weapon winfield = new Winfield();
			winfield.Specifications();

			winfield = new ExtendedMagazineWeapon(winfield);
			winfield.Specifications();

			winfield = new ImprovedLensWeapon(winfield);
			winfield.Specifications();

			Console.ReadLine();
		}
	}
}
