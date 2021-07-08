using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lelli
{
    /// <summary>
    /// The implementation of the Interface ICoin.
    /// </summary>
    public class Coin : Box, ICoin
    {
        private const double YDIR = 1.0; //y direction allows to coin to move downward when the move method is called

        ///<summary>
        ///inizialize a coin with X and Y position, and the coin image (coin.png).
        /// <param name="xLoc">   X coordinate.
        /// <param name="yLoc">   Y coordinate.
        ///</summary>
        public Coin initializeCoin(double xLoc, double yLoc)
        {
            this.XLoc = xLoc;
            this.YLoc = yLoc;
            this.YDir = YDIR;
            this.SetImage("coin.png");
            return this;
        }
    }
}
