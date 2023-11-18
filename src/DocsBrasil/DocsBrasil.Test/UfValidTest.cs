using DocsBrasil.Extensions;

namespace DocsBrasil.Test
{
    [TestClass]
    public class UfValidTest
    {
        [TestMethod]
        [DataRow("AC")]
        [DataRow("AL")]
        [DataRow("AM")]
        [DataRow("AP")]
        [DataRow("BA")]
        [DataRow("CE")]
        [DataRow("DF")]
        [DataRow("ES")]
        [DataRow("GO")]
        [DataRow("MA")]
        [DataRow("MG")]
        [DataRow("MS")]
        [DataRow("MT")]
        [DataRow("PA")]
        [DataRow("PB")]
        [DataRow("PE")]
        [DataRow("PI")]
        [DataRow("PR")]
        [DataRow("RJ")]
        [DataRow("RN")]
        [DataRow("RO")]
        [DataRow("RR")]
        [DataRow("RS")]
        [DataRow("SC")]
        [DataRow("SE")]
        [DataRow("SP")]
        [DataRow("TO")]
        public void UfValida(string uf)
        {
            Assert.IsTrue(uf.IsUf());
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("PS")]
        [DataRow("GHJ")]
        [DataRow("D")]
        [DataRow("FD")]
        [DataRow("BN")]
        [DataRow("RE")]
        [DataRow("DX")]
        [DataRow("SO")]
        [DataRow("LK")]
        [DataRow("VX")]
        public void UfInvalida(string uf)
        {
            Assert.IsFalse(uf.IsUf());
        }
    }
}
