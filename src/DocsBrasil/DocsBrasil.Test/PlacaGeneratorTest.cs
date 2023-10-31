using DocsBrasil.Fakes;
using DocsBrasil.Extensions;

namespace DocsBrasil.Test
{
    [TestClass]
    public class PlacaGeneratorTest
    {
        [TestMethod]
        public void GeneratePlacas()
        {
            string[] placas = Gerador.Placas(10);
            Assert.AreEqual(placas.Length, 10);

            foreach (string placa in placas)
                Assert.IsTrue(placa.IsPlaca());
        }

        [TestMethod]
        public void GeneratePlacasCinza()
        {
            string[] placas = Gerador.PlacasCinza(10);
            Assert.AreEqual(placas.Length, 10);

            foreach (string placa in placas)
            {
                Assert.IsTrue(placa.IsPlacaCinza());
                Assert.IsFalse(placa.IsPlacaMercosul());
            }
        }

        [TestMethod]
        public void GeneratePlacasMercosul()
        {
            string[] placas = Gerador.PlacasMercosul(10);
            Assert.AreEqual(placas.Length, 10);

            foreach (string placa in placas)
            {
                Assert.IsTrue(placa.IsPlacaMercosul());
                Assert.IsFalse(placa.IsPlacaCinza());
            }
        }
    }
}
