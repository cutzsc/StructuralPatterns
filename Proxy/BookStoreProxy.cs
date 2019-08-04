using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
	class BookStoreProxy : IBook
	{
		List<Page> pages;
		BookStore store;

		public BookStoreProxy()
		{
			pages = new List<Page>();
		}

		public void Dispose()
		{

		}

		public Page GetPage(int number)
		{
			Page page = pages.FirstOrDefault(p => p.Number == number);
			if (page == null)
			{
				if (store == null)
					store = new BookStore();
				page = store.GetPage(number);
				pages.Add(page);
			}
			return page;
		}
	}
}
