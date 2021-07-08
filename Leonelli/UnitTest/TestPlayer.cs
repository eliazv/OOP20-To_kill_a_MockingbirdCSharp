using Leonelli;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class TestPlayer
    {
        private static double INITIAL_XLOC = 10;
        private static double INITIAL_YLOC = 10;
        private static double SCROLL_DIR = 1;
        private static int INITIAL_COINS = 0;
        private IPlayer player;

        [TestInitialize]
        public void setUpPlayer()
        {
            this.player = new Player("bird.png", INITIAL_XLOC, INITIAL_YLOC);
        }

        [TestMethod]
        public void testMainPlayer()
        {
            this.player.Move();
            Assert.Equals(SCROLL_DIR, player.YDir);
            Assert.Equals(INITIAL_YLOC + 1, player.YLoc);

            Assert.Equals(INITIAL_COINS, player.Coins);
            player.IncreaseCoins();
            Assert.Equals(INITIAL_COINS + 1, player.Coins);
        }
    }
}
