using DocsBrasil.Extensions;
namespace DocsBrasil.Test
{
    [TestClass]
    public class PlacaValidTest
    {
        [TestMethod]
        [DataRow("ABC1234")]
        [DataRow("ABC-1234")]
        [DataRow("ABC1C34")]
        [DataRow("ABC-1C34")]
        public void PlacaIsValid(string placa)
        {
            Assert.IsTrue(placa.IsPlaca());
        }

        [TestMethod]
        [DataRow("ABCE000")]
        [DataRow("ABC-E000")]
        [DataRow("AB0E000")]
        [DataRow("ABB0Z00")]
        [DataRow("")]
        public void PlacaIsNotValid(string placa)
        {
            Assert.IsFalse(placa.IsPlaca());
        }

        [TestMethod]
        [DataRow("ABC1C34")]
        [DataRow("ABC-1C34")]
        public void PlacaMercosulIsValid(string placa)
        {
            Assert.IsTrue(placa.IsPlacaMercosul());
        }

        [TestMethod]
        [DataRow("ABC1234")]
        [DataRow("ABC-1234")]
        [DataRow("ABC1K34")]
        [DataRow("ABC-1K34")]
        public void PlacaMercosulIsNotValid(string placa)
        {
            Assert.IsFalse(placa.IsPlacaMercosul());
        }

        [TestMethod]
        [DataRow("ABC1234")]
        [DataRow("ABC-1234")]
        public void PlacaCinzalIsValid(string placa)
        {
            Assert.IsTrue(placa.IsPlacaCinza());
        }

        [TestMethod]
        [DataRow("ABC1C34")]
        [DataRow("ABC-1C34")]
        [DataRow("A8C1034")]
        [DataRow("AA-1134")]
        public void PlacaCinzaIsNotValid(string placa)
        {
            Assert.IsFalse(placa.IsPlacaCinza());
        }
    }
}