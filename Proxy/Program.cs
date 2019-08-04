using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
	class Program
	{
		static void Main(string[] args)
		{
			using (IBook book = new BookStoreProxy())
			{
				Page page = book.GetPage(1);
				Console.WriteLine(page.Text);

				page = book.GetPage(2);
				Console.WriteLine(page.Text);

				page = book.GetPage(1);
				Console.WriteLine(page.Text);
			}

			Console.ReadLine();
		}
	}
}
