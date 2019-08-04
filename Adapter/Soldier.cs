using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class Soldier
	{
		private float damage;

		public Soldier()
		{
			damage = 7.12f;
		}

		public void Fire()
		{
			Console.WriteLine($"Soldier attacks for {damage} damage");
		}
	}
}
