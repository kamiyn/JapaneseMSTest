using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JapaneseMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(false, "IsTrue TestMethod1()");
        }

        [TestMethod]
        public void Japaneseテストメソッド1()
        {
            Assert.IsTrue(false, "IsTrue Japaneseテストメソッド1()");
        }
    }
}
