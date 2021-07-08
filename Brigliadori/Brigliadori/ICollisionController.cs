using System;
using System.Collections.Generic;
using System.Text;

namespace Brigliadori
{
    public interface ICollisionController
    {
        /// <summary>
        /// method that checks the collision with the vehicle v.
        /// <\summary>
        /// <param name="v"></param>
        bool collideWithVehicles(Box v);

        /// <summary>
        /// method that checks collision with coins
        /// <\summary>
        /// <param name="c"></param>
        bool collideWithCoins(Box c);

        /// <summary>
        /// Check if the player is too close to trees and blocks input to prevent overlapping.
        /// <\summary>
        /// <param name="tree"></param>
        void checkTrees(Box tree);

        /// <summary>
        /// Check if the player is too close to borders.
        /// <\summary>
        bool checkBorders();

        /// <summary>
        /// blocks a certain direction.
        /// <\summary>
        /// <param name="dir"></param>
        void block(Directions dir);

        /// <summary>
        /// blocks all directions.
        /// <\summary>
        void unBlockAll();

        /// <summary>
        /// check if the player can move in a certain direction.
        /// @param dir     the direction i want to check.
        /// @return true if the direction is blocked, false otherwise.
        /// <\summary>
        /// <param name="dir"></param>
        bool checkDir(Directions dir);
    }
}
