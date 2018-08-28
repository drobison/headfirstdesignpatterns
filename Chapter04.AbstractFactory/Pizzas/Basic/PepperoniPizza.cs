using System;
using Chapter04.AbstractFactory.Ingredients;

namespace Chapter04.AbstractFactory.Pizzas.Basic
{
    public class PepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Veggies = _pizzaIngredientFactory.CreateVeggies();
            Pepperoni = _pizzaIngredientFactory.CreatePepperoni();
        }
    }
}