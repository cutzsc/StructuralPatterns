using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class Warrior
	{
		private float damage;

		public Warrior()
		{
			damage = 13.52f;
		}

		public void Attack()
		{
			Console.WriteLine($"Warrior attacks for {damage} damage");
		}
	}
}
