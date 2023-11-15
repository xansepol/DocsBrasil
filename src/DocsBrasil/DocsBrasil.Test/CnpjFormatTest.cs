using DocsBrasil.Fakes;

namespace DocsBrasil.Test
{
    [TestClass]
    public class CnpjFormatTest
    {
        [TestMethod]
        public void Format()
        {
            string cnpj = Gerador.Cnpj(format: true);
            Assert.AreEqual(cnpj.Length, 18);
        }

        [TestMethod]
        public void NotFormat()
        {
            string cnpj = Gerador.Cnpj(format: false);
            Assert.AreEqual(cnpj.Length, 14);
        }
    }
}
