using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	class Group : Unit
	{
		List<Unit> units = new List<Unit>();

		public Group(string name)
			: base(name) { }

		public void Add(Unit u)
		{
			units.Add(u);
		}

		public void Remove(Unit u)
		{
			units.Remove(u);
		}

		public override void Move()
		{
			Console.WriteLine($"Подконтрольная группа №{Name} движется.");
			foreach (Unit u in units)
			{
				u.Move();
			}
		}

		public override void Select()
		{
			Console.WriteLine($"Выбрана подконтрольная группа №{Name}");
			Console.WriteLine("Состав:");
			foreach (Unit u in units)
			{
				Console.WriteLine($"\t{u.Name}");
			}
		}
	}
}
