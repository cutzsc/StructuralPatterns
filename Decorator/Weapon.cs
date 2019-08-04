using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	abstract class Weapon
	{
		public string Name { get; protected set; }

		public Weapon(string name)
		{
			Name = name;
		}

		public abstract int MagazineVolume();
		public abstract float AimingMultiplier();
		public virtual void Specifications()
		{
			Console.WriteLine($"Название: {Name}\tмагазин: {MagazineVolume()}\tМножитель оптического прицела: x{AimingMultiplier()}");
		}
	}
}
