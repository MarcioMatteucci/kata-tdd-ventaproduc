using App;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class ImpuestoTest
    {
        private Impuesto imp;

        [SetUp]
        public void init()
        {
            imp = new Impuesto();
        }

        [TestCase("CA", ExpectedResult = 0.875)]
        [TestCase("TX", ExpectedResult = 0.15)]
        [TestCase("NV", ExpectedResult = 0.12)]
        [TestCase("", ExpectedResult = 0.10)]
        public decimal Get_Impuesto(string estado)
        {
            return imp.getImpuesto(estado);
        }
    }
}
