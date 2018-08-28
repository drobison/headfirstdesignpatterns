using Chapter04.Pizzas;
using Chapter04.Pizzas.Chicago;
using Chapter04.PizzaStores;
using NUnit.Framework;

namespace Chapter04.Tests
{
    [TestFixture]
    public class AbstractPizzaStoreTests
    {
        [Test]
        public void CanCreatePizza_NYCheese()
        {
            var nyPizzaStore = new NYPizzaStore();
            nyPizzaStore.OrderPizza(PizzaType.Cheese);
        }

        [Test]
        public void CanCreatePizza_ChicagoStyleCheese()
        {
            var nyPizzaStore = new ChicagoPizzaStore();
            nyPizzaStore.OrderPizza(PizzaType.Cheese);
            new ChicagoStyleCheesePizza().Cut();

        }
    }
}
