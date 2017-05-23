using PotterKata;
using NUnit.Framework;
using PotterBooks;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PotterKataTests
{
	[TestFixture]
	public class ThePotterPricerTest
	{
		private PotterPricerBasket basket;

		[SetUp]
		public void SetUp()
		{
			basket = new PotterPricerBasket();
		}

		[Test]
		public void NoBookCostsNothing()
		{
			Equals(0);
		}

		[Test]
		public void Book1Costs8Dollars()
		{
			basket.AddBook(HarryPotterBook.FIRST);
			Equals(8);
		}
		public void Book2Costs8Dollars()
		{
			basket.AddBook(HarryPotterBook.SECOND);
			Equals(8);
		}
		public void Book3Costs8Dollars()
		{
			basket.AddBook(HarryPotterBook.THIRD);
			Equals(8);
		}
		public void Book4Costs8Dollars()
		{
			basket.AddBook(HarryPotterBook.FOURTH);
			Equals(8);
		}
		public void Book5Costs8Dollars()
		{
			basket.AddBook(HarryPotterBook.FIFTH);
			Equals(8);
		}
		public void Book6Costs8Dollars()
		{
			basket.AddBook(HarryPotterBook.SIXTH);
			Equals(8);
		}
		public void Book7Costs8Dollars()
		{
			basket.AddBook(HarryPotterBook.SEVENTH);
			Equals(8);
		}
		[TestCase]
		public void AssertTotalPrice()
		{
			int ActualPrice = basket.GetTotal();
			Equals(ActualPrice, ("value"));
		}
	}
}
