using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	class Winfield : Weapon
	{
		public Winfield()
			: base("Винфилд") { }

		public override float AimingMultiplier()
		{
			return 1.5f;
		}

		public override int MagazineVolume()
		{
			return 6;
		}
	}
}
