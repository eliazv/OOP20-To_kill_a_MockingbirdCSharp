using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace Brigliadori
{
    public class ImageLoader
    {

        Image img;
        private String filename = null;

        public ImageLoader(String filename)
        {
            this.filename = filename;
            using (System.IO.Stream BitmapStream = System.IO.File.Open("src\\" +  filename, System.IO.FileMode.Open))
            {
                try
                {
                    img = Image.FromStream(BitmapStream);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(""+ e.StackTrace);
                    Console.WriteLine("The image cannot be accessed. Exiting...");
                    System.Environment.Exit(1);
                }
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
