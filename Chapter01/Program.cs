using Chapter01.Ducks;
using Chapter01.FlyBehaviors;
using System;

namespace Chapter01
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformFly();
            mallard.PerformQuack();

            Console.WriteLine();

            Duck model = new ModelDuck();
            model.Display();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
