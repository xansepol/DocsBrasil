using DocsBrasil.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocsBrasil.Test
{
    [TestClass]
    public class CpfValidTest
    {
        [TestMethod]
        [DataRow("693.903.120-00")]
        [DataRow("65808900026")]
        [DataRow("955897246")]
        [DataRow("503335612-79")]
        public void CpfIsValid(string cpf)
        {
            Assert.IsTrue(cpf.IsCpf());
        }

        [TestMethod]
        [DataRow("693.903.120-01")]
        [DataRow("065808900026")]
        [DataRow("322 852 022-61")]
        [DataRow("955897216")]
        [DataRow("503335612-09")]
        [DataRow("")]
        [DataRow("00000000000")]
        [DataRow("55555555555")]
        public void CpfIsNotValid(string cpf)
        {
            Assert.IsFalse(cpf.IsCpf());
        }
    }
}
