using Chapter01.FlyBehaviors;
using Chapter01.QuackBehaviors;
using System;

namespace Chapter01
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; protected set; }
        public IQuackBehavior QuackBehavior { get; protected set; }

        public Duck()
        {
        }

        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
