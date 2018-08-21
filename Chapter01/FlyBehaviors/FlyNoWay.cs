using System;

namespace Chapter01.FlyBehaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
