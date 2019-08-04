using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	class Tree
	{
		protected TreeModel model;

		protected Vector position;

		public Tree(TreeModel model)
		{
			this.model = model;
		}

		public virtual void Draw(Vector position)
		{
			this.position = position;
			Console.WriteLine($"Отрисовано дерево {model.Name} в позиции {position.x}, {position.y}, {position.z}");
		}

		public virtual void Print()
		{
			Console.WriteLine($"Tree position: {position}");
		}
	}
}
