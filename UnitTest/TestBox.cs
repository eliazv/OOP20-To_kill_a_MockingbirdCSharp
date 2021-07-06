using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Maffi;

namespace UnitTest
{
    /// <summary>
    /// Test that verify the correct creation and working of a box.
    /// </summary>
    [TestClass]
    public class TestBox
    {
        //local variables for the test
        private const int XLOC = 5;
        private const int YLOC = 10;
        private const double DIR = 1;
        private const double XLOCAFTERMOVE = 501;
        private const double YLOCAFTERMOVE = -199;
        
        [TestMethod]
        public void TestMethod1()
        {
            Box box = new BoxImpl();
            BoxImpl box2 = new BoxImpl("grass.png", XLOC, YLOC);

            box2.XDir = DIR;
            box2.YDir = DIR;
            box2.Move();

            Assert.AreEqual(null, box.GetImage());
            Assert.AreEqual(0, box.XLoc);
            Assert.AreEqual(0, box.YLoc);

            
            Assert.AreEqual(XLOCAFTERMOVE, box2.XLoc);
            Assert.AreEqual(YLOCAFTERMOVE, box2.YLoc);
        }
    }
}
