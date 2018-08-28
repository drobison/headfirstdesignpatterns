using System;
using Chapter04.AbstractFactory.Pizzas;
using Chapter04.AbstractFactory.PizzaStores;
using NUnit.Framework;

namespace Chapter04.AbstractFactory.Tests
{
    [TestFixture]
    public class AbstractFactoryTests
    {
        [Test]
        public void TestDriver()
        {
            AbstractPizzaStore nyStore = new NYPizzaStore();
            AbstractPizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine($"Ethan ordered a {pizza} ");
        }
    }
}
