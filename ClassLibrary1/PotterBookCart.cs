using PotterBooks;
using System.Collections.Generic;
using System.Linq;
using System;

namespace PotterKata
{
	public class PotterBookCart
	{
		List<HarryPotterBook> cart = new List<HarryPotterBook>();

		public decimal Add()
		{
			return 0;
		}
		public decimal Add(HarryPotterBook book)
		{
			cart.Add(book);
			return CalculateTotal();
		}

		public decimal CalculateTotal()
		{
			var booksByTitle = cart.GroupBy(b => b.Title).Select(item => new {
				title = item.Key,
				count = item.Count()
			});
			
			var totalNumberOfBooksInCart = cart.Count();
			var numberOfBooksRecievingDiscount = cart.GroupBy(b => b.Title).Count();
			var numberOfBooksWithoutDiscount = totalNumberOfBooksInCart -
				numberOfBooksRecievingDiscount;

			Console.WriteLine(totalNumberOfBooksInCart);
			Console.WriteLine(numberOfBooksRecievingDiscount);
			Console.WriteLine(numberOfBooksWithoutDiscount);

			return cart.Count()*8;
		}
	
	}
}