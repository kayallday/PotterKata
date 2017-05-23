using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterKata;
using NUnit.Framework;

namespace PotterKataTests
{
	[TestFixture]
	public class ThePotterPricerTest
	{
		private PotterPricerBasket basket;
		[SetUp]
		public void setUp()
		{ 
			basket = new PotterPricerBasket();
		}

		[Test]
		public void noBookCostsNothing()
		{
			int ActualPrice = basket.getTotal();
			NUnit.Framework.Assert.AreEqual(ActualPrice, (0));
		}


		[Test]
		public void oneBookCosts8Euros()
		{
			basket.addBook();
		}
	}
}
