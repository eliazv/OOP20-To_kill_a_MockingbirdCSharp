using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Maffi
{
    public class BoxImpl : Box {
        private const int MAP_SIZE = 800;
        private const int BOX_SIZE = 100;
        //local variables
        private ImageLoader imgLoader;
        private double xloc, yloc;
        private double xdir, ydir;
        private String name;

        
        public BoxImpl()
        {
            this.xloc = 0;
            this.yloc = 0;
            this.xdir = 0;
            this.ydir = 0;
        }

        public BoxImpl( String filename)
        {
            this.SetImage(filename);
            this.name = filename;
        }

        public BoxImpl( String filename,  double xloc,  double yloc)
        {
            this.SetImage(filename);
            this.xloc = xloc * BOX_SIZE;
            this.yloc = MAP_SIZE - yloc * BOX_SIZE;
            this.name = filename;
        }

        public  void SetImage( String filename)
        {
            imgLoader = new ImageLoader(filename);
            this.name = filename;
        }

        public ImageLoader GetImage()
        {
            return imgLoader;
        }
     
        public String GetName
        {
            get { return this.name; }
        }
       
        public double XLoc
        {
            get { return xloc; }
            set { xloc = value; }
        }

        public double YLoc
        {
            get { return yloc; }
            set { yloc = value; }
        }

        public double XDir
        {
            get { return xdir; }
            set { xdir = value; }
        }

        public double YDir
        {
            get { return ydir; }
            set { ydir = value; }
        }

        public int GetWidth
        {
            get { return imgLoader.getImgWidth(); }
        }

        public int GetHeight
        {
            get { return imgLoader.getImgHeight(); }
        }

        public void Paint( Graphics g,  Panel panel)
        {
            //if no image has been uploaded, will be drawn an empy square: otherwise will be drawn a square filled with the image 
            if (imgLoader == null)
            {
                g.DrawRectangle(new Pen(Brushes.Black), new Rectangle((int) xloc, (int) yloc, BOX_SIZE, BOX_SIZE));
            }
            else
            {
                
                g.DrawImage(imgLoader.getImage(), new Point((int) xloc,(int) yloc));
            }

        }

        
        public void Move()
        {
            this.xloc += this.xdir;
            this.yloc += this.ydir;
        }

    }
}
