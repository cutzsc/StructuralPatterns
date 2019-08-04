using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	class WoodProcessingFacade
	{
		Lumberjack lumberjack;
		Carpenter carpenter;
		Forester forester;
		WoodPorter woodPorter;

		public WoodProcessingFacade(Lumberjack l, Carpenter c, Forester f, WoodPorter wp)
		{
			lumberjack = l;
			carpenter = c;
			forester = f;
			woodPorter = wp;
		}

		public void Start()
		{
			forester.Checkout();
			lumberjack.Chop();
			woodPorter.BringWood();
			carpenter.HandleWood();
		}

		public void Stop()
		{
			Console.WriteLine("Бросить инструменты");
		}
	}
}
