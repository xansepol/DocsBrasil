using DocsBrasil.Extensions;

namespace DocsBrasil.Test
{
    [TestClass]
    public class RenavamValidTest
    {
        [TestMethod]
        [DataRow("00923200070")]
        [DataRow("693829516")]
        [DataRow("331410389")]
        public void RenavamIsValid(string renavam)
        {
            Assert.IsTrue(renavam.IsRenavam());
        }

        [TestMethod]
        [DataRow("01923200070")]
        [DataRow("000693829516")]
        [DataRow("033141O389")]
        public void RenavamIsNotValid(string renavam)
        {
            Assert.IsFalse(renavam.IsRenavam());;
        }
    }
}
