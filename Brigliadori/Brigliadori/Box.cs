using System;

namespace Brigliadori
{
    public class Box : IBox
    {
        private static int MAP_SIZE = 800;
        //local variables
        private ImageLoader imgLoader;
        public double xloc { get; set; }
        public double yloc { get; set; }
        public double xdir { get; set; }
        public double ydir { get; set; }
        private String name;

        public Box()
        {
            this.xloc = 0;
            this.yloc = 0;
            this.xdir = 0;
            this.ydir = 0;
        }

        public Box(String filename)
        {
            this.setImage(filename);
            this.name = filename;
        }

        public Box(String filename, double xloc, double yloc)
        {
            this.setImage(filename);
            this.xloc = xloc;
            this.yloc = MAP_SIZE - yloc;
            this.name = filename;
        }
        public void setImage(String filename)
        {
            imgLoader = new ImageLoader(filename);
            this.name = filename;
        }

        public ImageLoader getImage()
        {
            return imgLoader;
        }

        public String getName()
        {
            return this.name;
        }

        public void move()
        {
            this.xloc += this.xdir;
            this.yloc += this.ydir;
        }

        public int getWidth()
        {
            return imgLoader.getImgWidth();
        }

        public int getHeight()
        {
            return imgLoader.getImgHeight();
        }
    }
}
