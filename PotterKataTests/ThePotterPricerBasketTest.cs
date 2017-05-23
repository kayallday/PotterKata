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
			int ActualPrice = basket.GetTotal();
			NUnit.Framework.Assert.AreEqual(ActualPrice, (0));
		}
		[Test]
		public void OneBookCosts8Dollars()
		{
			basket.AddBook(HarryPotterBook.FIRST);
			int ActualPrice = basket.GetTotal();
			NUnit.Framework.Assert.AreEqual(ActualPrice, (8));
		}
	}
}
