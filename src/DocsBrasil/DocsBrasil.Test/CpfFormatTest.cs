using DocsBrasil.Fakes;

namespace DocsBrasil.Test
{
    [TestClass]
    public class CpfFormatTest
    {
        [TestMethod]
        public void Format()
        {
            string cpf = Gerador.Cpf(format: true);
            Assert.AreEqual(cpf.Length, 14);
        }

        [TestMethod]
        public void NotFormat()
        {
            string cpf = Gerador.Cpf(format: false);
            Assert.AreEqual(cpf.Length, 11);
        }
    }
}
