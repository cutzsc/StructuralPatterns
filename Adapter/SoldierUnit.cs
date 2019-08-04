using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class SoldierUnit : IUnit
	{
		private Soldier soldier;

		public SoldierUnit(Soldier soldier)
		{
			this.soldier = soldier;
		}

		public void DealDamage()
		{
			soldier.Fire();
		}
	}
}
