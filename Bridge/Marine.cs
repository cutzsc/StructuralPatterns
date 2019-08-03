using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	class Marine : Unit
	{
		public Marine(IWeapon weapon)
			: base(weapon) { }

		public override void Savage()
		{
			Console.WriteLine("Who's next.");
		}
	}
}
