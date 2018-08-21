using Chapter03.Beverages;

namespace Chapter03.Condiments
{
    public class Mocha : ICondimentDecorator
    {
        private IBeverage _beverage;

        public Mocha(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public string GetDescription => _beverage.GetDescription + ", Mocha";

        public BeverageSize Size { get; set; }

        public double Cost()
        {
            return _beverage.Cost() + .20;
        }
    }
}
