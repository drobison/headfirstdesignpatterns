using System.Collections.Generic;

namespace Chapter04.AbstractFactory.Ingredients
{
    public interface IPizzaIngredientFactory
    {
        Dough.Dough CreateDough();
        Sauce.Sauce CreateSauce();
        Cheese.Cheese CreateCheese();
        List<Veggies.Veggies> CreateVeggies();
        Pepperoni.Pepperoni CreatePepperoni();
        Clams.Clams CreateClams();
    }
}
