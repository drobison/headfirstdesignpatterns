using System.Collections.Generic;
using Chapter04.AbstractFactory.Ingredients.Cheese;
using Chapter04.AbstractFactory.Ingredients.Clams;
using Chapter04.AbstractFactory.Ingredients.Dough;
using Chapter04.AbstractFactory.Ingredients.Pepperoni;
using Chapter04.AbstractFactory.Ingredients.Sauce;
using Chapter04.AbstractFactory.Ingredients.Veggies;

namespace Chapter04.AbstractFactory.Ingredients
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough.Dough CreateDough()
        {
            return new ThinCrustDough();
        }


        public Sauce.Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese.Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public List<Veggies.Veggies> CreateVeggies()
        {
            return new List<Veggies.Veggies>{ new Garlic(), new Onion(), new Mushroom(), new RedPepper()};
        }

        public Pepperoni.Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams.Clams CreateClams()
        {
            return new FreshClams();
        }
    }
}