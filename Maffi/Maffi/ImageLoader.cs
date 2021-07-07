using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Maffi
{
    public class ImageLoader
    {
        /**
        * local variables.
        */
        Image img;
        private String filename = null;

        public ImageLoader(String filename)
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

        public String getFileName()
        {
            return filename;
        }

        public Image getImage()
        {
            return img;
        }
    }
}
