using Chapter04.Pizzas;
using Chapter04.Pizzas.California;

namespace Chapter04.PizzaStores
{
    public class CaliforniaPizzaStore : AbstractPizzaStore
    {
        public override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = null;

            if (pizzaType == PizzaType.Cheese)
            {
                pizza = new CaliforniaStyleCheesePizza();
            }
            else if (pizzaType == PizzaType.Veggie)
            {
                pizza = new CaliforniaStyleVeggiePizza();
            }
            else if (pizzaType == PizzaType.Pepperoni)
            {
                pizza = new CaliforniaStylePepperoniPizza();
            }
            else if (pizzaType == PizzaType.Clam)
            {
                pizza = new CaliforniaStyleClamPizza();
            }

            return pizza;
        }
    }
}