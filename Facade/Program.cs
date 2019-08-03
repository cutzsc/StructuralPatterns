using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	class Program
	{
		static void Main(string[] args)
		{
			Lumberjack l = new Lumberjack();
			Forester f = new Forester();
			WoodPorter wp = new WoodPorter();
			Carpenter c = new Carpenter();

			WoodProcessingFacade lumbermill = new WoodProcessingFacade(l, c, f, wp);

			lumbermill.Start();
			Console.WriteLine();
			lumbermill.Stop();

			Console.ReadLine();
		}
	}
}
