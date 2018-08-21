using System;

namespace Chapter01.QuackBehaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}