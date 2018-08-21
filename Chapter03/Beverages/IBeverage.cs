namespace Chapter03.Beverages
{
    public interface IBeverage
    {
        string GetDescription { get; }
        double Cost();
        BeverageSize Size {get;set;}
    }
}
