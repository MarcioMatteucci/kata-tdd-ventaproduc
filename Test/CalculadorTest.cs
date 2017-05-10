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
            var resul = calcu.getTotal(cant, precio,"");
            Assert.AreEqual(0m, resul);
        }

        [TestCase(120, 0)]
        [TestCase(10, 0)]
        [TestCase(320, 0.000)]
        [TestCase(0, 0)]
        [TestCase(1230, 0.0)]
        public void Get_Total_Precio_EsCero(int cant, decimal precio)
        {
            var resul = calcu.getTotal(cant, precio,"");
            Assert.AreEqual(0m, resul);
        }

        [TestCase(1, 1.1, ExpectedResult = 1.1)]
        [TestCase(120, 1, ExpectedResult = 120)]
        [TestCase(3, 150, ExpectedResult = 450)]
        [TestCase(5, 50, ExpectedResult = 250)]
        [TestCase(100, 9.999, ExpectedResult = 999.9)]
        public decimal Get_Total_Monto_Menor_1000(int cant, decimal precio)
        {
            return calcu.getTotal(cant, precio,"");
        }

        [TestCase(100, 10, ExpectedResult = 970)]
        [TestCase(10, 499.999, ExpectedResult = 4849.9903)]
        [TestCase(30, 150.54, ExpectedResult = 4380.714)]
        public decimal Get_Total_Monto_Entre_1000y5000(int cant, decimal precio)
        {
            return calcu.getTotal(cant, precio,"");
        }

        [TestCase(5000, 1, ExpectedResult = 4750)]
        [TestCase(5000, 1.112, ExpectedResult = 5282)]
        [TestCase(9999, 1, ExpectedResult = 9499.05)]
        public decimal Get_Total_Monto_Entre_5000y10000(int cant, decimal precio)
        {
            return calcu.getTotal(cant, precio,"");
        }

        [TestCase(10000, 1, ExpectedResult = 9200)]
        [TestCase(10000, 1.432, ExpectedResult = 13174.4)]
        public decimal Get_Total_Monto_Entre_10000y15000(int cant, decimal precio)
        {
            return calcu.getTotal(cant, precio,"");
        }

        [TestCase(15000, 1, ExpectedResult = 13500)]
        [TestCase(15000, 1.432, ExpectedResult = 19332)]
        public decimal Get_Total_Monto_Entre_15000y50000(int cant, decimal precio)
        {
            return calcu.getTotal(cant, precio,"");
        }

        [TestCase(50000, 1, ExpectedResult = 42500)]
        [TestCase(50000, 1.432, ExpectedResult = 60860)]
        public decimal Get_Total_Monto_MasDe_50000(int cant, decimal precio)
        {
            return calcu.getTotal(cant, precio,"");
        }
    }
}
