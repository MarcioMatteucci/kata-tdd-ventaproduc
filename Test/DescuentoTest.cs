using App;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class DescuentoTest
    {
        private Descuento desc;

        [SetUp]
        public void init ()
        {
            desc = new Descuento();
        }

        [TestCase(500, ExpectedResult = 0)]
        [TestCase(999.99, ExpectedResult = 0)]
        [TestCase(0.0001, ExpectedResult = 0)]
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(1500, ExpectedResult = 0.03)]
        [TestCase(4999.99, ExpectedResult = 0.03)]
        [TestCase(1000, ExpectedResult = 0.03)]
        [TestCase(5000, ExpectedResult = 0.05)]
        [TestCase(7500.23, ExpectedResult = 0.05)]
        [TestCase(9999.99, ExpectedResult = 0.05)]
        [TestCase(10000, ExpectedResult = 0.08)]
        [TestCase(12000.231, ExpectedResult = 0.08)]
        [TestCase(14999.99, ExpectedResult = 0.08)]
        [TestCase(15000, ExpectedResult = 0.1)]
        [TestCase(35000.1234, ExpectedResult = 0.1)]
        [TestCase(49999.999, ExpectedResult = 0.1)]
        [TestCase(50000, ExpectedResult = 0.15)]
        [TestCase(12322221.332, ExpectedResult = 0.15)]
        public decimal Get_Descuento(decimal subtotal)
        {
            return desc.getDescuentoBySubtotal(subtotal);
        }
    }
}
