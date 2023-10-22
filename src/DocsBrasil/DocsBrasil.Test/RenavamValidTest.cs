using DocsBrasil.Extensions;

namespace DocsBrasil.Test
{
    [TestClass]
    public class RenavamValidTest
    {
        [TestMethod]
        public void RenavamIsValid()
        {
            Assert.IsTrue("00923200070".IsRenavam());
            Assert.IsTrue("693829516".IsRenavam());
            Assert.IsTrue("331410389".IsRenavam());
        }

        [TestMethod]
        public void RenavamIsNotValid()
        {
            Assert.IsFalse("01923200070".IsRenavam());
            Assert.IsFalse("000693829516".IsRenavam());
            Assert.IsFalse("033141O389".IsRenavam());
        }
    }
}
