using PotterKata;
using NUnit.Framework;
using PotterBooks;

namespace PotterKataTests
{
	[TestFixture]
	public class ThePotterBookCart
	{
		private PotterBookCart shoppingCart;

		[SetUp]
		public void SetUp()
		{
			shoppingCart = new PotterBookCart();
		}

		//[Test]
		//public void Given0BooksThenTotalIs0()
		//{
		//	var total = shoppingCart.Add();
		//	Assert.AreEqual(0, total);
		//}

		//[Test]
		//public void Given1BookThenTotalIs8()
		//{
		//	shoppingCart.Add(new HarryPotterBook("Sorcerer's Stone"));
		//	Assert.AreEqual(8, shoppingCart.CalculateTotal());
		//}

		[Test]
		public void Given2BooksThatAreTheSameTheTotalIs16()
		{
			shoppingCart.Add(new HarryPotterBook("Sorcerer's Stone"));
			shoppingCart.Add(new HarryPotterBook("Sorcerer's Stone"));

			Assert.AreEqual(16, shoppingCart.CalculateTotal());
		}

		//[Test]
		//public void Given2DifferentBooksReturnsTotalWith5PercentDiscountApplied()
		//{
		//	shoppingCart.Add(new HarryPotterBook("Sorcerer's Stone"));
		//	shoppingCart.Add(new HarryPotterBook("Chamber of Secrets"));

		//	Assert.AreEqual(15.20, shoppingCart.CalculateTotal());
		//}
	}
}