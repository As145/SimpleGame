using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        SimpleGame G1 = new simpleGame();

        [TestMethod]

        public void TestMethod1()
        {
            int x = G1.Bullet;
            Assert.AreNotEqual(x, 6);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int y = G1.Point;
            Assert.AreEqual(y, 0);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int z = G1.Shot;
            Assert.AreEqual(z, G1.Shot1 + G1.Shot2);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int a = G1.Shot;
            Assert.AreNotEqual(a, 6);
        }
    }
}



