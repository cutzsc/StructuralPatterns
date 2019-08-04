using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	class ImprovedLensWeapon : WeaponDecorator
	{
		public ImprovedLensWeapon(Weapon weapon)
			: base($"{weapon.Name}, с улучшенным прицелом", weapon) { }

		public override float AimingMultiplier()
		{
			return weapon.AimingMultiplier() + 2f;
		}

		public override int MagazineVolume()
		{
			return weapon.MagazineVolume();
		}
	}
}
