using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	class ExtendedMagazineWeapon : WeaponDecorator
	{
		public ExtendedMagazineWeapon(Weapon weapon)
			: base($"{weapon.Name}, с увеличенным магазином", weapon) { }

		public override float AimingMultiplier()
		{
			return weapon.AimingMultiplier();
		}

		public override int MagazineVolume()
		{
			return weapon.MagazineVolume() + 3;
		}
	}
}
