using System;
using System.Collections.Generic;
using System.Text;

namespace Leonelli
{
    public interface IPlayerMovement : IBox
    {
        /// <summary>
        /// move the player in one direction
        /// </summary>
        void MoveDirection(Directions direction);
    }
}
