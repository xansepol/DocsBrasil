using DocsBrasil.Extensions;

namespace DocsBrasil.Test
{
    [TestClass]
    public class CnpjValidTest
    {
        [TestMethod]
        [DataRow("70.923.810/0001-03")]
        [DataRow("11090501000122")]
        [DataRow("116604300001-56")]
        [DataRow("2491171000196")]
        public void CnpjIsValid(string cnpj)
        {
            Assert.IsTrue(cnpj.IsCnpj());
        }

        [TestMethod]
        [DataRow("70.923.810/0001-08")]
        [DataRow("11090501400122")]
        [DataRow("11,660,430/0001-56")]
        [DataRow("249I171000196")]
        [DataRow("")]
        [DataRow("11111111111111")]
        public void CnpjIsNotValid(string cnpj)
        {
            Assert.IsFalse(cnpj.IsCnpj());
        }
    }
}
