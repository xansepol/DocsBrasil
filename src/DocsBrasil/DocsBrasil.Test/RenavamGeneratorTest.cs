using DocsBrasil.Extensions;
using DocsBrasil.Fakes;

namespace DocsBrasil.Test
{
    [TestClass]
    public class RenavamGeneratorTest
    {
        [TestMethod]
        public void GenerateRenavam()
        {
            string renavam = Gerador.Renavam();
            Assert.AreEqual(renavam.Length, 11);
            Assert.IsTrue(renavam.IsRenavam());
        }

        [TestMethod]
        public void GenerateRenavams()
        {
            string[] renavams = Gerador.Renavams(100);
            Assert.AreEqual(renavams.Length, 100);
            foreach (string renavam in renavams)
                Assert.IsTrue(renavam.IsRenavam());
        }
    }
}
