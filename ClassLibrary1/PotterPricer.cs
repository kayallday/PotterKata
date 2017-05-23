using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterKata
{
	public class Book
	{
		public string Title { get; set; }
		public int Id { get; private set; }
		public double Price { get; private set; }
		public int DiscountId { get; set; }

		public Book(int id, double price, int id, double price, int discountId = int.MinValue)
			: this(String.Empty, id, price, discountId)
		{ }
		public Book(string title, int id, double price, int discountId = int.MinValue)
		{
			Title = title;
			Id = id;
			Price = price;
			DiscountId = discountId;
		}
    }
}
