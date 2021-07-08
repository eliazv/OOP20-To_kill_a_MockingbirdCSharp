using System;
using System.Collections.Generic;
using System.Text;


namespace Leonelli
{
    public class Player :Box, IPlayer 
    {
        private static double MAP_SCROLL = 1;
        private int collectedCoins;

        public Player(String filename , double xPos, double yPos)
        {
            this.SetImage(filename);
            this.XLoc=xPos;
            this.YLoc=yPos;
            this.YDir=MAP_SCROLL;
            this.collectedCoins = 0;
        }

        public int Coins
    {
        get { return this.collectedCoins; }
        set { this.collectedCoins = value; }
    }

        public void IncreaseCoins()
        {
            this.collectedCoins++;
        }
    }
}
