using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	abstract class WeaponDecorator : Weapon
	{
		protected Weapon weapon;

		public WeaponDecorator(string name, Weapon weapon)
			: base(name)
		{
			this.weapon = weapon;
		}
	}
}
