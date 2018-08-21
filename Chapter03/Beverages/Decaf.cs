namespace Chapter03.Beverages
{
    public class Decaf : IBeverage
    {
        public string GetDescription => "Decaf";

        public BeverageSize Size { get; set; }

        public double Cost()
        {
            return 1.05;
        }
    }
}
