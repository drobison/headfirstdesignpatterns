using Chapter01.FlyBehaviors;
using Chapter01.QuackBehaviors;
using System;

namespace Chapter01.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
