namespace Chapter03.Beverages
{
    public class HouseBlend : IBeverage
    {
        public string GetDescription => "House Blend Coffee";

        public BeverageSize Size { get; set; }

        public double Cost()
        {
            return .89;
        }
    }
}
