using Chapter04.Pizzas;
using Chapter04.Pizzas.Chicago;

namespace Chapter04.PizzaStores
{
    public class ChicagoPizzaStore : AbstractPizzaStore
    {
        public override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = null;

            if (pizzaType == PizzaType.Cheese)
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (pizzaType == PizzaType.Veggie)
            {
                pizza = new ChicagoStyleVeggiePizza();
            }
            else if (pizzaType == PizzaType.Pepperoni)
            {
                pizza = new ChicagoStylePepperoniPizza();
            }
            else if (pizzaType == PizzaType.Clam)
            {
                pizza = new ChicagoStyleClamPizza();
            }

            return pizza;
        }
    }
}