using Chapter03.Beverages;
using Chapter03.Condiments;

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage espresso = new Espresso();
            espresso.Size = BeverageSize.Venti;
            espresso.Print();

            IBeverage doubleMochaWhip = new DarkRoast();
            doubleMochaWhip = new Mocha(doubleMochaWhip);
            doubleMochaWhip = new Mocha(doubleMochaWhip);
            doubleMochaWhip = new Whip(doubleMochaWhip);
            doubleMochaWhip.Size = BeverageSize.Grande;
            doubleMochaWhip.Print();

            var superDrink = new Whip(new Mocha(new Soy(new HouseBlend())));
            superDrink.Size = BeverageSize.Venti;
            superDrink.Print();
        }
    }
}
