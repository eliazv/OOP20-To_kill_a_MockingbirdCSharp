using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leonelli
{
    public class Box :IBox
    {

        private const int MAP_SIZE = 800;
        private const int BOX_SIZE = 100;
        private ImageLoader imgLoader;
        private readonly double xloc, yloc, xdir, ydir;
        private string name;

        public Box()
        {
            this.xloc = 0;
            this.yloc = 0;
            this.xdir = 0;
            this.ydir = 0;
        }

        public Box( String filename)
        {
            this.SetImage(filename);
            this.name = filename;
        }

        public Box(string filename, double xloc, double yloc)
        {
            this.SetImage(filename);
            this.xloc = xloc * BOX_SIZE;
            this.yloc = MAP_SIZE - yloc * BOX_SIZE;
            this.name = filename;
        }

        public string Name { get; set; }

        public double XLoc { get; set; }

        public double YLoc { get; set; }

        public double YDir { get; set; }

        public double XDir { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public void SetImage(string filename)
        {
            imgLoader = new ImageLoader(filename);
            this.name = filename;
        }

        public ImageLoader GetImage()
        {
            return imgLoader;
        }

        public void Move()
        {
            this.XLoc += this.XDir;
            this.YLoc += this.YDir;
        }
    }
}
