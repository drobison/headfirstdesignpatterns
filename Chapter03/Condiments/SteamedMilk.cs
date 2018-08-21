using Chapter03.Beverages;

namespace Chapter03.Condiments
{
    public class SteamedMilk : ICondimentDecorator
    {
        private IBeverage _beverage;

        public SteamedMilk(IBeverage beverage)
        {
            _beverage = beverage;
        }    

        public string GetDescription => _beverage.GetDescription + ", Steamed Milk";

        public BeverageSize Size { get; set; }

        public double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }
}
