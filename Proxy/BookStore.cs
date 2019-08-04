using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
	class BookStore : IBook
	{
		PageContext db;

		public BookStore()
		{
			db = new PageContext();
			db.Pages = new List<Page>();
			db.Pages.Add(new Page() { Id = 1, Number = 1, Text = "Это первая страница книги." });
			db.Pages.Add(new Page() { Id = 2, Number = 2, Text = "Это ВТОРАЯ страница книги." });
		}

		public void Dispose()
		{

		}

		public Page GetPage(int number)
		{
			return db.Pages.FirstOrDefault(p => p.Number == number);
		}
	}
}
