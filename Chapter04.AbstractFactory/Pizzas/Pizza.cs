using System;
using System.Collections.Generic;
using System.Text;
using Chapter04.AbstractFactory.Ingredients.Cheese;
using Chapter04.AbstractFactory.Ingredients.Clams;
using Chapter04.AbstractFactory.Ingredients.Dough;
using Chapter04.AbstractFactory.Ingredients.Pepperoni;
using Chapter04.AbstractFactory.Ingredients.Sauce;
using Chapter04.AbstractFactory.Ingredients.Veggies;

namespace Chapter04.AbstractFactory.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public List<Veggies> Veggies { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }
        public Clams Clam { get; set; }

        protected Pizza()
        {
            Veggies = new List<Veggies>();
        }

        public abstract void Prepare();

        public void Bake() => Console.WriteLine("Bake for 25 minutes at 350");

        public virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");

        public void Box() => Console.WriteLine("Place pizza in official PizzaStore box");
        public void SetName(string name) => this.Name = name;

        public string GetName() => Name;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"---- {Name} ----");

            if (Dough != null)
            {
                sb.AppendLine(Dough.ToString());
            }
            if (Sauce != null)
            {
                sb.AppendLine(Sauce.ToString());
            }
            if (Cheese != null)
            {
                sb.AppendLine(Cheese.ToString());
            }
            if (Veggies != null)
            {
                sb.AppendLine(string.Join(",", Veggies));
            }
            if (Clam != null)
            {
                sb.AppendLine(Clam.ToString());
            }
            if (Pepperoni != null)
            {
                sb.AppendLine(Pepperoni.ToString());
            }

            return sb.ToString();
        }
    }
}