using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	abstract class Unit
	{
		public string Name { get; private set; }

		public Unit(string name)
		{
			Name = name;
		}

		public virtual void Select()
		{
			Console.WriteLine($"{Name} selected.");
		}

		public virtual void Move()
		{
			Console.WriteLine($"{Name} moves.");
		}
	}
}
