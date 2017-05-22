using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterKata;

namespace PotterKataTests
{
	[TestClass]
	public class ThePotterPricer
	{
		[TestMethod]
		public void NoBookCostsNothing()
		{
			PotterBookOrder order = new PotterBookOrder();
			order.GetTotal();
		}

	}
}
