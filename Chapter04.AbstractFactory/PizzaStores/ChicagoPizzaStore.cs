using Chapter04.AbstractFactory.Ingredients;
using Chapter04.AbstractFactory.Pizzas;
using Chapter04.AbstractFactory.Pizzas.Basic;

namespace Chapter04.AbstractFactory.PizzaStores
{
    public class ChicagoPizzaStore : AbstractPizzaStore
    {
        public override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = null;

            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();


            if (pizzaType == PizzaType.Cheese)
            {
                pizza = new CheesePizza(ingredientFactory);
            }
            else if (pizzaType == PizzaType.Veggie)
            {
                pizza = new VeggiePizza(ingredientFactory);
            }
            else if (pizzaType == PizzaType.Pepperoni)
            {
                pizza = new PepperoniPizza(ingredientFactory);
            }
            else if (pizzaType == PizzaType.Clam)
            {
                pizza = new ClamPizza(ingredientFactory);
            }

            return pizza;
        }
    }
}