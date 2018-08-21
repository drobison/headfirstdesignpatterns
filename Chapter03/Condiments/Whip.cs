using Chapter03.Beverages;

namespace Chapter03.Condiments
{
    public class Whip : ICondimentDecorator
    {
        private IBeverage _beverage;

        public Whip(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string GetDescription => _beverage.GetDescription + ", Whip";

        public BeverageSize Size { get; set; }

        public double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }
}
