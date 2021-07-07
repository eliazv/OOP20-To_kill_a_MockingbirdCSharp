using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavatta
{
    public class Strip : IStrip
    {

        private const int STRIP_LENGTH = 8;
        private const int PROBABILITY_OF_STRIPENV = 3;
        private const int PROBABILITY_OF_SPAWN_OBSTACLE = 4;
        private const string IMAGETREE = "Tree.png";

        private IList<Box> boxesStrip;
        private Random gen = new Random();
        private StripEnvironment env;


        public IList<Box> InitializeRndStrip(int y)
        {

            this.boxesStrip = new List<Box>();
            int rndEnv = gen.Next(PROBABILITY_OF_STRIPENV);

            switch (rndEnv)
            {
                case 0:
                    env = StripEnvironment.ROAD;
                    for (int i = 0; i < STRIP_LENGTH; i++)
                    {
                        this.boxesStrip.Add(new Box("Road.png", i, y));

                    }
                    break;

                case 1:
                    env = StripEnvironment.RAIL;
                    for (int i = 0; i < STRIP_LENGTH; i++)
                    {
                        this.boxesStrip.Add(new Box("Rail.png", i, y));
                    }
                    break;

                case 2:
                    env = StripEnvironment.GRASS;
                    for (int i = 0; i < STRIP_LENGTH; i++)
                    {
                        this.boxesStrip.Add(InsertBoxObstacles("Grass.png", "Tree.png", i, y));
                    }
                    break;
                default:
                    break;
            }
            return this.boxesStrip;
        }

        public Box InsertBoxObstacles(string background, string specialBlock, int x, int y)
        {

            Box oneBlock;
            int rand = gen.Next(PROBABILITY_OF_SPAWN_OBSTACLE);

            if (rand == 3)
            {
                oneBlock = new Box(specialBlock, x, y);
            }
            else
            {
                oneBlock = new Box(background, x, y);
            }

            return oneBlock;
        }

         
        public void SetStripEnvironment(string background)
        {
            switch (background)
            {
                case "Road.png":
                    env = StripEnvironment.ROAD;
                    break;
                case "Rail.png":
                    env = StripEnvironment.RAIL;
                    break;
                case "Grass.png":
                    env = StripEnvironment.GRASS;
                    break;
                default:
                    break;
            }
        }

        public StripEnvironment GetStripEnvironment { get => this.env; }

        public IList<Box> InitializeSpecificStrip( string background,  int y)
        {

            this.boxesStrip = new List<Box>();
            this.SetStripEnvironment(background);
            for (int i = 0; i < STRIP_LENGTH; i++)
            {
                this.boxesStrip.Add(new Box(background, i, y));
            }

            return this.boxesStrip;
        }


        public IList<Box> InitializeSpecificStrip(string background, string specialBlock, int y)
        {

            this.boxesStrip = new List<Box>();
            this.SetStripEnvironment(background);
            for (int i = 0; i < STRIP_LENGTH; i++)
            {
                this.boxesStrip.Add(InsertBoxObstacles(background, specialBlock, i, y));
            }
            return this.boxesStrip;
        }

         
        public IList<Box> GetStrip { get => this.boxesStrip; }
        
         
        public Box GetBoxOfStrip(int x)
        {
            return this.boxesStrip[x];
        }
    }
}
