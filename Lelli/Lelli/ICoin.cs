using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lelli
{
    public interface ICoin : IBox
    {

        ///<summary>
        ///inizialize a coin with X and Y position, and the coin image (coin.png).
        /// <param name="xLoc">   X coordinate.
        /// <param name="yLoc">   Y coordinate.
        ///</summary>
        Coin initializeCoin(double xLoc, double yLoc);
    }
}
