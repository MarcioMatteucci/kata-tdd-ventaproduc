using App;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class CalculadorTest
    {
        private Calculador calcu;

        [SetUp]
        public void init()
        {
            calcu = new Calculador();
        }

        [TestCase(0, 15.5)]
        [TestCase(0, 152.0)]
        [TestCase(0, 1235)]
        [TestCase(0, 105.23)]
        [TestCase(0, 115.99)]
        [TestCase(0, 0)]
        public void Get_Total_Cant_EsCero(int cant, decimal precio)
        {
            var resul = calcu.getTotal(cant, precio);
            Assert.AreEqual(0m, resul);
        }

        [TestCase(120, 0)]
        [TestCase(10, 0)]
        [TestCase(320, 0.000)]
        [TestCase(0, 0)]
        [TestCase(1230, 0.0)]
        public void Get_Total_Precio_EsCero(int cant, decimal precio)
        {
            var resul = calcu.getTotal(cant, precio);
            Assert.AreEqual(0m, resul);
        }

        [TestCase(1, 1.1, ExpectedResult = 1.1)]
        [TestCase(120, 1, ExpectedResult = 120)]
        [TestCase(3, 150, ExpectedResult = 450)]
        [TestCase(5, 50, ExpectedResult = 250)]
        [TestCase(120, 10, ExpectedResult = 1200)]
        [TestCase(120, 33.412, ExpectedResult = 4009.44)]
        public decimal Get_Total_PrecioYCant_DistCero(int cant, decimal precio)
        {
            return calcu.getTotal(cant, precio);
        }
    }
}
