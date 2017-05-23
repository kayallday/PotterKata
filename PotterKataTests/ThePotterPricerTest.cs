using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterKata;

namespace PotterKataTests
{
	[TestClass]
	public class ThePotterPricerTest
	{
		public void noBookCostsNothing()
		{
			PotterPricer basket = new PotterPricer();
			basket.getTotal();
		}
	}
}
