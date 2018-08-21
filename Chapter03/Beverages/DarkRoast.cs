using Chapter03.Beverages;

namespace Chapter03
{
    public class DarkRoast : IBeverage
    {
        public string GetDescription => "Dark Roast Coffee";

        public BeverageSize Size { get; set; }

        public double Cost()
        {
            return .99;
        }
    }
}