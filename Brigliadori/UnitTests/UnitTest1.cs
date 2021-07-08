using Brigliadori;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TreeTest()
        {
            Box player = new Box("bird.png", 100.0, 100.0);
            CollisionController cc = new CollisionController(player);
            cc.setup();
            Box tree = new Box("Tree.png", 200.0, 100.0);
            Box tree2 = new Box("Tree.png", 100.0, 200.0);
            Assert.AreEqual(false, cc.checkDir(Directions.LEFT));
            Assert.AreEqual(false, cc.checkDir(Directions.RIGHT));
            Assert.AreEqual(false, cc.checkDir(Directions.DOWN));
            Assert.AreEqual(false, cc.checkDir(Directions.UP));
            cc.checkTrees(tree);
            Assert.AreEqual(false, cc.checkDir(Directions.LEFT));
            Assert.AreEqual(true, cc.checkDir(Directions.RIGHT));
            Assert.AreEqual(false, cc.checkDir(Directions.DOWN));
            Assert.AreEqual(false, cc.checkDir(Directions.UP));
            cc.unBlockAll();
            cc.checkTrees(tree2);
            Assert.AreEqual(false, cc.checkDir(Directions.LEFT));
            Assert.AreEqual(false, cc.checkDir(Directions.RIGHT));
            Assert.AreEqual(false, cc.checkDir(Directions.DOWN));
            Assert.AreEqual(true, cc.checkDir(Directions.UP));
            cc.unBlockAll();
        }

        [TestMethod]
        public void VehicleTest()
        {
            Box player = new Box("bird.png", 100.0, 100.0);
            CollisionController cc = new CollisionController(player);
            cc.setup();
            Box vehicle1 = new Box("Tree.png", 100.0, 100.0);
            Box vehicle2 = new Box("Tree.png", 100.0, 300.0);
            Assert.AreEqual(true, cc.collideWithVehicles(vehicle1));
            Assert.AreEqual(false, cc.collideWithVehicles(vehicle2));
        }

        [TestMethod]
        public void BorderTest()
        {
            Box player = new Box("bird.png", 100.0, 100.0);
            CollisionController cc = new CollisionController(player);
            cc.setup();
            Assert.AreEqual(false, cc.checkBorders());
            player.xloc = 0.0;
            cc.checkBorders();
            Assert.AreEqual(true, cc.checkDir(Directions.LEFT));
            Assert.AreEqual(false, cc.checkDir(Directions.RIGHT));
            Assert.AreEqual(false, cc.checkDir(Directions.DOWN));
            Assert.AreEqual(false, cc.checkDir(Directions.UP));
            player.xloc = 700.0;
            cc.unBlockAll();
            cc.checkBorders();
            Assert.AreEqual(false, cc.checkDir(Directions.LEFT));
            Assert.AreEqual(true, cc.checkDir(Directions.RIGHT));
            Assert.AreEqual(false, cc.checkDir(Directions.DOWN));
            Assert.AreEqual(false, cc.checkDir(Directions.UP));
            player.xloc = 100.0;
            player.yloc = 800.0;
            Assert.AreEqual(true, cc.checkBorders());
        }
    }
}
