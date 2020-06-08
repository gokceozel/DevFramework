using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 0;
            x= 5;
            Assert.IsTrue(x < 6,"gec");
        }
    }
}
