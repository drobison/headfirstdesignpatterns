using System;
using System.Collections.Generic;

namespace Chapter04.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; }

        protected Pizza()
        {
            Toppings = new List<string>();
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            Toppings.ForEach(x => Console.WriteLine(" " + x));
        }

        public void Bake() => Console.WriteLine("Bake for 25 minutes at 350");

        public virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");

        public void Box() => Console.WriteLine("Place pizza in official PizzaStore box");

        public string GetName() => Name;
    }

    public abstract class AbstractPizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; }
        public string Pepperoni { get; set; }

        protected AbstractPizza()
        {
            Toppings = new List<string>();
        }

        public abstract void Prepare();

        public void Bake() => Console.WriteLine("Bake for 25 minutes at 350");

        public virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");

        public void Box() => Console.WriteLine("Place pizza in official PizzaStore box");

        public void SetName(string name) => this.Name = name;

        public string GetName() => Name;
    }

}