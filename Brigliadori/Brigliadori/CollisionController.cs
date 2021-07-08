using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Brigliadori
{
    public class CollisionController : ICollisionController
    {
        private const int ERROR = 20;
        private const double MAXHEIGH = 40.0;
        private const double LEFTBORDERLIMIT = 0.0;
        private const double RIGHTBORDERLIMIT = 700.0;
        private const double MINHEIGH = 750.0;
        private bool fals = false;

        private Dictionary<Directions, bool> enabledDir = new Dictionary<Directions, bool>();
        private Box player;

        public CollisionController(Box player)
        {
            this.player = player;
        }

        public void setup()
        {
            unBlockAll();
        }

        public void unBlockAll()
        {
            enabledDir.Remove(Directions.LEFT);
            enabledDir.Remove(Directions.RIGHT);
            enabledDir.Remove(Directions.UP);
            enabledDir.Remove(Directions.DOWN);
        }

        public void block(Directions dir)
        {
            enabledDir.Remove(dir);
            enabledDir.TryAdd(dir, false);
        }

        public bool checkDir(Directions dir)
        {
            return enabledDir.TryGetValue(dir, out fals);
        }

        public bool collideWithVehicles(Box v)
        {
            Rectangle borderVehicle = new Rectangle((int)v.xloc - ERROR, (int)v.yloc - ERROR, v.getWidth() - ERROR, 1);
            Rectangle borderPlayer = new Rectangle((int)player.xloc - ERROR, (int)player.yloc - ERROR,
                    player.getWidth() - ERROR, player.getHeight() - ERROR);
            return borderPlayer.IntersectsWith(borderVehicle);
        }

        public bool collideWithCoins(Box c)
        {
            Rectangle borderCoin = new Rectangle((int)c.xloc - ERROR, (int)c.yloc - ERROR,
                    c.getWidth() - ERROR, c.getHeight() - ERROR);
            Rectangle borderPlayer = new Rectangle((int)player.xloc - ERROR, (int)player.yloc - ERROR,
                    player.getWidth() - ERROR, player.getHeight() - ERROR);
            return borderPlayer.IntersectsWith(borderCoin);
        }

        public void checkTrees(Box tree)
        {
            Rectangle borderTree = new Rectangle((int)(tree.xloc) - ERROR, (int)(tree.yloc) - ERROR,
                    tree.getWidth() - ERROR, tree.getHeight() - ERROR);

            if (borderTree.IntersectsWith(new Rectangle((int)player.xloc + 100 - ERROR, (int)player.yloc - ERROR,
                    player.getWidth() - ERROR, player.getHeight() - ERROR)))
            {
                enabledDir.Remove(Directions.RIGHT);
                enabledDir.TryAdd(Directions.RIGHT, false);
            }
            if (borderTree.IntersectsWith(new Rectangle((int)player.xloc - 100 - ERROR, (int)player.yloc - ERROR,
                    player.getWidth() - ERROR, player.getHeight() - ERROR)))
            {
                enabledDir.Remove(Directions.LEFT);
                enabledDir.TryAdd(Directions.LEFT, false);
            }
            if (borderTree.IntersectsWith(new Rectangle((int)player.xloc - ERROR, (int)player.yloc + 100 - ERROR,
                    player.getWidth() - ERROR, player.getHeight() - ERROR)))
            {
                enabledDir.Remove(Directions.DOWN);
                enabledDir.TryAdd(Directions.DOWN, false);
            }
            if (borderTree.IntersectsWith(new Rectangle((int)player.xloc - ERROR, (int)player.yloc - 100 - ERROR,
                    player.getWidth() - ERROR, player.getHeight() - ERROR)))
            {
                enabledDir.Remove(Directions.UP);
                enabledDir.TryAdd(Directions.UP, false);
            }
        }

        public bool checkBorders()
        {
            if (player.xloc == RIGHTBORDERLIMIT)
            {
                enabledDir.Remove(Directions.RIGHT);
                enabledDir.TryAdd(Directions.RIGHT, false);
            }
            if (player.xloc == LEFTBORDERLIMIT)
            {
                enabledDir.Remove(Directions.LEFT);
                enabledDir.TryAdd(Directions.LEFT, false);
            }
            if (player.yloc <= MAXHEIGH)
            {
                enabledDir.Remove(Directions.UP);
                enabledDir.TryAdd(Directions.UP, false);
            }
            return player.yloc >= MINHEIGH;
        }
    }
}


