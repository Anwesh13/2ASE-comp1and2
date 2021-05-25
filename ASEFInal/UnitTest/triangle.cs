using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ASEFInal;



namespace UnitTest
{
    /// <summary>
    /// Summary description for triangle
    /// </summary>
    [TestClass]
    public class triangle
    {
        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;

        public triangle()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            var t = new ASEFInal.Triangle();
            int xi1 = 100, yi1 = 200, xi2 = 200, yi2 = 200, xii1 = 200, yii1 = 200, xii2 = 200,
                yii2 = 200, xiii1 = 200, yiii1 = 200, xiii2 = 200, yiii2 = 200;
            t.set(texturestyle, bb, c1, xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2);
            Assert.AreEqual(100, t.xi1);
        }
    }
}
