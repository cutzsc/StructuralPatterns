using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class WarriorUnit : IUnit
	{
		private Warrior warrior;

		public WarriorUnit(Warrior warrior)
		{
			this.warrior = warrior;
		}

		public void DealDamage()
		{
			warrior.Attack();
		}
	}
}
