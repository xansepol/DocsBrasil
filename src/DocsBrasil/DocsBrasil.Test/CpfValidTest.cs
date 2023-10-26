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
        public void CpfIsValid()
        {
            Assert.IsTrue("693.903.120-00".IsCpf());
            Assert.IsTrue("65808900026".IsCpf());
            Assert.IsTrue("955897246".IsCpf());
            Assert.IsTrue("503335612-79".IsCpf());
        }

        [TestMethod]
        public void CpfIsNotValid()
        {
            Assert.IsFalse("693.903.120-01".IsCpf());
            Assert.IsFalse("065808900026".IsCpf());
            Assert.IsFalse("322 852 022-61".IsCpf());
            Assert.IsFalse("955897216".IsCpf());
            Assert.IsFalse("503335612-09".IsCpf());
            Assert.IsFalse("".IsCpf());
            Assert.IsFalse("00000000000".IsCpf());
            Assert.IsFalse("55555555555".IsCpf());
        }
    }
}
