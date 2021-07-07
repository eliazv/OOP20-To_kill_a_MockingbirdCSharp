using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Zavatta
{
    public class ImageLoader
    {

        Image img;
        private string filename = null;

        public ImageLoader(string filename)
        {
            this.filename = filename;
            using (System.IO.Stream BitmapStream = System.IO.File.Open(filename, System.IO.FileMode.Open))
            {
                img = Image.FromStream(BitmapStream);
            }
        }
        public int getImgWidth()
        {
            return img.Width;
        }
        public int getImgHeight()
        {
            return img.Height;
        }

        public string getFileName()
        {
            return filename;
        }

        public Image getImage()
        {
            return img;
        }
    }
}
