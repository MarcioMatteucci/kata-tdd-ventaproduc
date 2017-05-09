using App;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class DescuentoTest
    {
        [Test]
        public void Devuelve_Descuento_Monto_Menor_1000()
        {
            Descuento desc = new Descuento();
            var resul = desc.getDescuento(100);
            Assert.AreEqual(0, resul);
        }

    }
}
