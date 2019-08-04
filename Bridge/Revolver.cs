using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	class Revolver : IWeapon
	{
		public void Fire()
		{
			Console.WriteLine("Взвести курок.");
			Console.WriteLine("Спустить крючок.");
		}

		public void Reload()
		{
			Console.WriteLine("Вставить патроны в барабан");
		}
	}
}
