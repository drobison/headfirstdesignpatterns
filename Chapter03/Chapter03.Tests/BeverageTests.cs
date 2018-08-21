using Chapter03.Beverages;
using Chapter03.Condiments;
using NUnit.Framework;

namespace Chapter03.Tests
{
    [TestFixture]
    public class BeverageTests
    {
        [Test]
        public void DifferentSizesOfSoy_ShouldHaveDifferentCosts()
        {
            IBeverage tallBeverage = new DarkRoast();
            tallBeverage = new Soy(tallBeverage);
            Assert.AreEqual(1.09, tallBeverage.Cost()); //.99 + .10

            IBeverage grandeBeverage = new DarkRoast();
            grandeBeverage.Size = BeverageSize.Grande;
            grandeBeverage = new Soy(tallBeverage);
            Assert.AreEqual(1.14, tallBeverage.Cost()); //.99 + .15
        }
    }
}
