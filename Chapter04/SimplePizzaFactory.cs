using Chapter04.Pizzas;
using Chapter04.Pizzas.Basic;

namespace Chapter04
{
    /// <summary>
    /// Simple Factory Example - 117
    /// </summary>
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = null;

            if (pizzaType == PizzaType.Cheese)
            {
                pizza = new CheesePizza();
            }
            else if (pizzaType == PizzaType.Veggie)
            {
                pizza = new VeggiePizza();
            }
            else if (pizzaType == PizzaType.Pepperoni)
            {
                pizza = new PepperoniPizza();
            }
            else if (pizzaType == PizzaType.Clam)
            {
                pizza = new ClamPizza();
            }

            return pizza;
        }
    }
}