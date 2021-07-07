using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zavatta;

namespace UnitTest
{
    [TestClass]
    class TestStrip
    {
        [TestMethod]
        public void testStrip()
        {
            IStrip strip = new Strip();

            strip.InitializeRndStrip(6);
            Assert.AreEqual(8, strip.GetStrip.Count);

            strip.InitializeSpecificStrip("Grass.png", "Tree.png", 2);
            Assert.AreEqual(8, strip.GetStrip.Count);
            Assert.AreEqual(StripEnvironment.GRASS, strip.GetStripEnvironment);

            strip.InitializeSpecificStrip("Rail.png", 5);
            Assert.AreEqual(8, strip.GetStrip.Count);
            Assert.AreEqual("Rail.png", strip.GetBoxOfStrip(2).GetImage().getFileName());
            Assert.AreEqual(StripEnvironment.RAIL, strip.GetStripEnvironment);

        }
    }
}
