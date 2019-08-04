using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	class M16 : IWeapon
	{
		public void Fire()
		{
			Console.WriteLine("Нажать на крючок.");
		}

		public void Reload()
		{
			Console.WriteLine("Вставить магазин в автомат.");
		}
	}
}
