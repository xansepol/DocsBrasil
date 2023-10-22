using DocsBrasil.Extensions;
namespace DocsBrasil.Test
{
    [TestClass]
    public class PlacaValidTest
    {
        [TestMethod]
        public void PlacaIsValid()
        {
            Assert.IsTrue("ABC1234".IsPlaca());
            Assert.IsTrue("ABC-1234".IsPlaca());
            Assert.IsTrue("ABC1C34".IsPlaca());
            Assert.IsTrue("ABC-1C34".IsPlaca());
        }

        [TestMethod]
        public void PlacaIsNotValid()
        {
            Assert.IsFalse("ABCE000".IsPlaca());
            Assert.IsFalse("ABC-E000".IsPlaca());
            Assert.IsFalse("AB0E000".IsPlaca());
            Assert.IsFalse("ABB0Z00".IsPlaca());
        }

        [TestMethod]
        public void PlacaMercosulIsValid()
        {
            Assert.IsTrue("ABC1C34".IsPlacaMercosul());
            Assert.IsTrue("ABC-1C34".IsPlacaMercosul());
        }

        [TestMethod]
        public void PlacaMercosulIsNotValid()
        {
            Assert.IsFalse("ABC1234".IsPlacaMercosul());
            Assert.IsFalse("ABC-1234".IsPlacaMercosul());
            Assert.IsFalse("ABC1K34".IsPlacaMercosul());
            Assert.IsFalse("ABC-1K34".IsPlacaMercosul());
        }

        [TestMethod]
        public void PlacaCinzalIsValid()
        {
            Assert.IsTrue("ABC1234".IsPlacaCinza());
            Assert.IsTrue("ABC-1234".IsPlacaCinza());
        }

        [TestMethod]
        public void PlacaCinzaIsNotValid()
        {
            Assert.IsFalse("ABC1C34".IsPlacaCinza());
            Assert.IsFalse("ABC-1C34".IsPlacaCinza());
            Assert.IsFalse("A8C1034".IsPlacaCinza());
            Assert.IsFalse("AA-1134".IsPlacaCinza());
        }
    }
}