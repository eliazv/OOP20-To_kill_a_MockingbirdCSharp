using System;
using System.Collections.Generic;
using System.Text;

namespace Leonelli
{
    /// <summary>
    /// this interface contains method to handle the player
    /// </summary>
    public interface IPlayer : IBox
    {
        /// <summary>
        /// get the number of coins collected
        /// </summary>
        int Coins { get; set; }

        /// <summary>
        /// increase the number of collected coins
        /// </summary>
        void IncreaseCoins();
    }
}


