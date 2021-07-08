using System;

namespace Leonelli
{
    public class PlayerMovement : Player, IPlayerMovement
    {

        private static double X_MOVE = 100;
        private static double Y_MOVE = 100.2;

        public PlayerMovement(String filename, double xPos, double yPos) : base(filename, xPos, yPos){ }

        /// <summary>
        /// move character one box up
        /// </summary>
        private void GoUp()
        {

            this.YLoc = (this.YLoc - Y_MOVE);
        }

        /// <summary>
        /// move character one box down
        /// </summary>
        private void GoDown()
        {

            this.YLoc = this.YLoc + Y_MOVE;
        }

        /// <summary>
        /// move character one box left
        /// </summary>
        private void GoLeft()
        {

            this.XLoc = this.XLoc - X_MOVE;
        }

        /// <summary>
        /// move character one box right
        /// </summary>
        private void GoRight()
        {

            this.XLoc = this.XLoc + X_MOVE;
        }


        public void MoveDirection(Directions direction)
        {

            switch (direction)
            {
                case Directions.UP:
                    this.GoUp();
                    break;

                case Directions.DOWN:
                    this.GoDown();
                    break;

                case Directions.RIGHT:
                    this.GoRight();
                    break;

                case Directions.LEFT:
                    this.GoLeft();
                    break;

                default:
                    break;
            }
        }
    }
}
