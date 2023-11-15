using DocsBrasil.Fakes;

namespace DocsBrasil.Test
{
    [TestClass]
    public class PlacaFormatTest
    {
        [TestMethod]
        public void Format()
        {
            string placa = Gerador.Placa(format: true);
            Assert.AreEqual(placa.Length, 8);
        }

        [TestMethod]
        public void NonFormat()
        {
            string placa = Gerador.Placa(format: false);
            Assert.AreEqual(placa.Length, 7);
        }
    }
}
