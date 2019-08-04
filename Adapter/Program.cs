using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			Player p1 = new Player();

			Soldier s1 = new Soldier();
			Warrior w1 = new Warrior();

			// Без адаптера
			s1.Fire();
			w1.Attack();

			// С адаптером
			SoldierUnit sol = new SoldierUnit(s1);
			WarriorUnit war = new WarriorUnit(w1);
			
			p1.DealDamage(sol);
			p1.DealDamage(war);

			Console.ReadLine();
		}
	}
}