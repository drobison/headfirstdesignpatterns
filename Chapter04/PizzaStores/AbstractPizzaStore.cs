using Chapter04.Pizzas;

namespace Chapter04.PizzaStores
{
    public abstract class AbstractPizzaStore
    {

        public abstract Pizza CreatePizza(PizzaType pizzaType);

        public Pizza OrderPizza(PizzaType pizzaType)
        {
            dynamic pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}