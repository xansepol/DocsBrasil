using DocsBrasil.Extensions;
using DocsBrasil.Fakes;

namespace DocsBrasil.Test
{
    [TestClass]
    public class CnpjGeneratorTest
    {
        [TestMethod]
        public void GenerateCnpj()
        {
            string cnpj = Gerador.Cnpj();
            Assert.IsTrue(cnpj.IsCnpj());
        }

        [TestMethod]
        public void GenerateCnpjs()
        {
            string[] cnpjs = Gerador.Cnpjs(10);
            Assert.AreEqual(cnpjs.Length, 10);
        }
    }
}
