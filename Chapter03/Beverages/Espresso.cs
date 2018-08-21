namespace Chapter03.Beverages
{
    public class Espresso : IBeverage
    {
        public string GetDescription => "Espresso";

        public BeverageSize Size { get; set; }

        public double Cost()
        {
            return 1.99;
        }
    }
}
