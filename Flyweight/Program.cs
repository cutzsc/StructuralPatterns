using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	class Program
	{
		static void Main(string[] args)
		{

			TreeFactory fac = new TreeFactory();

			Tree t1 = fac.GetTree(typeof(Fir));
			t1.Draw(new Vector(1, 1, 1));
			Tree t2 = fac.GetTree(typeof(Fir));
			t2.Draw(new Vector(2, 2, 2));
			Tree t3 = fac.GetTree(typeof(Fir));
			t3.Draw(new Vector(3, 3, 3));

			t1.Print();
			t2.Print();

			Console.ReadLine();
		}
	}
}
