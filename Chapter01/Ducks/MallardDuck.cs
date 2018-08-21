using Chapter01.FlyBehaviors;
using Chapter01.QuackBehaviors;
using System;

namespace Chapter01
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new NormalQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I am a mallard duck");
        }
    }
}