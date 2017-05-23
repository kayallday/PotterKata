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
		public void OneBookCosts8Dollars()
		{
			basket.AddBook(HarryPotterBook.FIRST);
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
