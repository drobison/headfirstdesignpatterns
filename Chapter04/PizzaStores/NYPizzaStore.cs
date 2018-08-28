using Chapter04.Pizzas;
using Chapter04.Pizzas.NewYork;

namespace Chapter04.PizzaStores
{
    public class NYPizzaStore : AbstractPizzaStore
    {
        public override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = null;

            if (pizzaType == PizzaType.Cheese)
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (pizzaType == PizzaType.Veggie)
            {
                pizza = new NYStyleVeggiePizza();
            }
            else if (pizzaType == PizzaType.Pepperoni)
            {
                pizza = new NYStylePepperoniPizza();
            }
            else if (pizzaType == PizzaType.Clam)
            {
                pizza = new NYStyleClamPizza();
            }

            return pizza;
        }
    }
}