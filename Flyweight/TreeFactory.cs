using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	class TreeFactory
	{
		Dictionary<Type, TreeModel> trees = new Dictionary<Type, TreeModel>();

		public TreeFactory()
		{
			trees = new Dictionary<Type, TreeModel>()
			{
				[typeof(Fir)] = new Fir(),
				[typeof(Pine)] = new Pine(),
				[typeof(Spruce)] = new Spruce()
			};
		}

		public Tree GetTree(Type key)
		{
			if (!trees.ContainsKey(key))
				throw new ArgumentException($"Не найдено ни одного дерево по ключу {key.ToString()}");

			return new Tree(trees[key]);
		}
	}
}
