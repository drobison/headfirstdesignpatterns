using Chapter03.Beverages;
using System;

namespace Chapter03.Condiments
{
    public class Soy : ICondimentDecorator
    {
        private IBeverage _beverage;

        public Soy(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string GetDescription => _beverage.GetDescription + ", Soy";

        public BeverageSize Size { get; set; }

        public double Cost()
        {
            double soyCost;

            if (Size == BeverageSize.Tall)
                soyCost = .10d;
            else if (Size == BeverageSize.Grande)
                soyCost = .15d;
            else if (Size == BeverageSize.Venti)
                soyCost = .20d;
            else
                throw new NotSupportedException(nameof(Soy) + " does not support calculating cost for BeverageSize " + Size.ToString());

            return _beverage.Cost() + soyCost;
        }
    }
}
