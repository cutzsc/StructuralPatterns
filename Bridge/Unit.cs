using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	abstract class Unit
	{
		protected IWeapon weapon;
		public IWeapon Weapon
		{
			set
			{
				weapon = value;
			}
		}

		public Unit(IWeapon weapon)
		{
			this.weapon = weapon;
		}

		public virtual void Attack()
		{
			weapon.Reload();
			weapon.Fire();
		}

		public abstract void Savage();
	}
}
