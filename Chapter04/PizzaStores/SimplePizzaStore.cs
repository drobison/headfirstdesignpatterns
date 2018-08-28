using Chapter04.Pizzas;

namespace Chapter04.PizzaStores
{
    /// <summary>
    /// The simple pizza store takes advantage of the simple factory
    /// </summary>
    public class SimplePizzaStore
    {
        private readonly SimplePizzaFactory _factory;

        public SimplePizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        public Pizza CreatePizza(PizzaType pizzaType)
        {
            var pizza = _factory.CreatePizza(pizzaType);
            return pizza;
        }

        public Pizza OrderPizza(PizzaType pizzaType)
        {
            var pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}