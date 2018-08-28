using Chapter04.Pizzas;
using Chapter04.Pizzas.Basic;
using Chapter04.PizzaStores;
using NUnit.Framework;

namespace Chapter04.Tests
{
    [TestFixture]
    public class SimplePizzaStoreTests
    {
        private SimplePizzaStore _sut;

        [OneTimeSetUp]
        public void Setup()
        {
            _sut = new SimplePizzaStore(new SimplePizzaFactory());
        }

        [Test]
        public void CanCreatePizza_Cheese()
        {
            var pizzaType = PizzaType.Cheese;
            var result = _sut.CreatePizza(pizzaType);
            Assert.IsInstanceOf<Pizza>(result);
            Assert.IsInstanceOf<CheesePizza>(result);

        }

        [Test]
        public void CanCreatePizza_Veggie()
        {
            var pizzaType = PizzaType.Veggie;
            var result = _sut.CreatePizza(pizzaType);
            Assert.IsInstanceOf<Pizza>(result);
            Assert.IsInstanceOf<VeggiePizza>(result);
        }

        [Test]
        public void CanCreatePizza_Pepperoni()
        {
            var pizzaType = PizzaType.Pepperoni;
            var result = _sut.CreatePizza(pizzaType);
            Assert.IsInstanceOf<Pizza>(result);
            Assert.IsInstanceOf<PepperoniPizza>(result);
        }

        [Test]
        public void CanCreatePizza_Clam()
        {
            var pizzaType = PizzaType.Clam;
            var result = _sut.CreatePizza(pizzaType);
            Assert.IsInstanceOf<Pizza>(result);
            Assert.IsInstanceOf<ClamPizza>(result);
        }

        [Test]
        public void CanOrderPizza()
        {
            var pizzaType = PizzaType.Clam;
            var result = _sut.OrderPizza(pizzaType);
            Assert.IsInstanceOf<ClamPizza>(result);
        }
    }
}
