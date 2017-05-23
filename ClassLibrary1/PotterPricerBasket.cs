using PotterBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PotterKata
{
	public class PotterPricerBasket
	{
		private HarryPotterBook book;

		public int GetTotal()
		{
			return book == null ? 0: 8;
		}

		public void AddBook(HarryPotterBook book)
		{
			this.book = book;
		}
	}
}
