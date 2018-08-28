using System.Collections.Generic;
using Chapter04.AbstractFactory.Ingredients.Cheese;
using Chapter04.AbstractFactory.Ingredients.Clams;
using Chapter04.AbstractFactory.Ingredients.Dough;
using Chapter04.AbstractFactory.Ingredients.Pepperoni;
using Chapter04.AbstractFactory.Ingredients.Sauce;
using Chapter04.AbstractFactory.Ingredients.Veggies;

namespace Chapter04.AbstractFactory.Ingredients
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough.Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce.Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Cheese.Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public List<Veggies.Veggies> CreateVeggies()
        {
            return new List<Veggies.Veggies> { new EggPlant(), new Spinach(), new BlackOlives(), new RedPepper() };
        }

        public Pepperoni.Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams.Clams CreateClams()
        {
            return new FrozenClams();
        }
    }
}