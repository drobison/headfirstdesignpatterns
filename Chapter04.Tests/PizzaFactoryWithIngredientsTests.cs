using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter04.PizzaStores;
using NUnit.Framework;

namespace Chapter04.Tests
{
    [TestFixture]
    public class PizzaFactoryWithIngredientsTests
    {
        [Test]
        public void CanCreateNYPizza()
        {
            AbstractPizzaStore nyStore = new NYPizzaStore();
        }
    }
}
