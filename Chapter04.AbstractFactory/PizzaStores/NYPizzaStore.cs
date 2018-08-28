using Chapter04.AbstractFactory.Ingredients;
using Chapter04.AbstractFactory.Pizzas;
using Chapter04.AbstractFactory.Pizzas.Basic;

namespace Chapter04.AbstractFactory.PizzaStores
{
    public class NYPizzaStore : AbstractPizzaStore
    {
        public override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = null;

            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (pizzaType == PizzaType.Cheese)
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Cheese Pizza";
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