using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ASEFInal;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var r = new ASEFInal.Rectangle();
            int x = 200, y = 200, size = 100, size1 = 100;
            r.set(texturestyle, bb, c1, x, y, size, size1);
            Assert.AreEqual(200, r.x);
        }
    }
}
