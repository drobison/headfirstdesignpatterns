using System;

namespace Chapter03.Beverages
{
    public static class BeverageExtensions
    {
        public static void Print(this IBeverage beverage)
        {
            Console.WriteLine("{2} {0} {1:c}", beverage.GetDescription, beverage.Cost(), beverage.Size);
        }
    }
}
