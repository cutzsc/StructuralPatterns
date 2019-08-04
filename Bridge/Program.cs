using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
	class Program
	{
		static void Main(string[] args)
		{
			Unit cowboy = new Cowboy(new Revolver());
			Unit marine = new Marine(new M16());

			marine.Attack();
			marine.Weapon = new Revolver();
			marine.Savage();
			marine.Attack();

			Console.WriteLine("\n\n");
			cowboy.Attack();
			cowboy.Weapon = new M16();
			cowboy.Savage();
			cowboy.Attack();

			Console.ReadLine();
		}
	}
}
