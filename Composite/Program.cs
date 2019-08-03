using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
	class Program
	{
		static void Main(string[] args)
		{
			Group gr1 = new Group("3");
			Marine m1 = new Marine();
			Marine m2 = new Marine();
			Marauder md1 = new Marauder();

			m1.Select();
			gr1.Add(m1);
			gr1.Select();

			md1.Select();
			gr1.Add(md1);
			gr1.Select();

			gr1.Add(m2);
			gr1.Select();

			gr1.Move();

			Console.ReadLine();
		}
	}
}
