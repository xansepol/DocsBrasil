using DocsBrasil.Enums;
using DocsBrasil.Extensions;
using DocsBrasil.Fakes;

namespace DocsBrasil.Test
{
    [TestClass]
    public class CpfGeneratorTest
    {
        [TestMethod]
        public void GenerateCpf()
        {
            string cpf = Gerador.Cpf();
            Assert.IsTrue(cpf.IsCpf());
        }

        [TestMethod]
        public void GenerateCpfUf()
        {
            string cpfSP = Gerador.Cpf(UnidadesFederativas.SP);
            string cpfRS = Gerador.Cpf(UnidadesFederativas.RS);
            string cpfMG = Gerador.Cpf(UnidadesFederativas.MG);
            string cpfPR = Gerador.Cpf(UnidadesFederativas.PR);
            string cpfDF = Gerador.Cpf(UnidadesFederativas.DF);

            Assert.IsTrue(cpfSP.IsCpf());
            Assert.IsTrue(cpfRS.IsCpf());
            Assert.IsTrue(cpfMG.IsCpf());
            Assert.IsTrue(cpfPR.IsCpf());
            Assert.IsTrue(cpfDF.IsCpf());

            Assert.AreEqual(cpfSP[8], '8');
            Assert.AreEqual(cpfRS[8], '0');
            Assert.AreEqual(cpfMG[8], '6');
            Assert.AreEqual(cpfPR[8], '9');
            Assert.AreEqual(cpfDF[8], '1');
        }

        [TestMethod]
        public void GenerateCpfs()
        {
            string[] cpfs = Gerador.Cpfs(10);
            
            Assert.AreEqual(cpfs.Length, 10);

            foreach (string cpf in cpfs)
                Assert.IsTrue(cpf.IsCpf());
        }

        [TestMethod]
        public void GenerateCpfsUf()
        {
            string[] cpfs = Gerador.Cpfs(10, UnidadesFederativas.AC);

            Assert.AreEqual(cpfs.Length, 10);

            foreach(string cpf in cpfs)
            {
                Assert.IsTrue(cpf.IsCpf());
                Assert.AreEqual(cpf[8], '2');
            }
        }
    }
}
