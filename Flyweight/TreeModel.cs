using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	class Model { }
	class Texture { }

	abstract class TreeModel
	{
		protected Model mesh;
		protected Texture text;

		public abstract string Name { get; protected set; }

		public TreeModel()
		{
			mesh = new Model();
			text = new Texture();
		}
	}
}
