using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	class Cowboy : Unit
	{
		public Cowboy(IWeapon weapon)
			: base(weapon) { }

		public override void Savage()
		{
			Console.WriteLine("You're already dead.");
		}
	}
}
