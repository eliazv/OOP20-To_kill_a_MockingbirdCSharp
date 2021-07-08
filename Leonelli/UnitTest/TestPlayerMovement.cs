using Leonelli;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class TestPlayerMovement
    {
        private static double X_MOVE = 100;
        private static double Y_MOVE = 100.2;
        private static double INITIAL_XLOC = 10;
        private static double INITIAL_YLOC = 10;
        private IPlayerMovement player;

        [TestInitialize]
        public void setUpPlayer()
        {
            this.player = new PlayerMovement("bird.png", INITIAL_XLOC, INITIAL_YLOC);
        }

        [TestMethod]
        public void testMainPlayerMovement()
        {
            this.player.MoveDirection(Directions.UP);
            Assert.Equals(this.player.YLoc, INITIAL_YLOC - Y_MOVE);
            this.player.MoveDirection(Directions.LEFT);
            Assert.Equals(this.player.XLoc, INITIAL_XLOC - X_MOVE);

        }
    }
}
