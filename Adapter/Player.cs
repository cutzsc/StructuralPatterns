using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class Player
	{
		public void DealDamage(IUnit unit)
		{
			unit.DealDamage();
		}
	}
}
