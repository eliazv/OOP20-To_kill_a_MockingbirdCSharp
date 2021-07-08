using System;
using System.Collections.Generic;
using System.Text;

namespace Brigliadori
{
    interface IBox
    {

        /// <summary>
        /// manages the X location of the specified box.
        /// </summary>
        double xloc { get; set; }

        /// <summary>
        /// manages the Y location of the specified box.
        /// </summary>
        double yloc { get; set; }

        /// <summary>
        /// manages the X direction of the specified box.
        /// </summary>
        double xdir { get; set; }

        /// <summary>
        /// manages the Y direction of the specified box.
        /// </summary>
        double ydir { get; set; }

        /// <summary>
        /// set an image (via filename) for the specified box.
        /// </summary>
        /// <param name="filename"></param>
        public void setImage(String filename);

        /// <summary>
        /// returns the image of the specified box.
        /// </summary>
        public ImageLoader getImage();

        /// <summary>
        /// returns the name of the specified box.
        /// </summary>
        public String getName();

        /// <summary>
        /// Move the box
        /// </summary>
        public void move();

        /// <summary>
        /// method that return the width of the image.
        /// </summary>
        public int getWidth();

        /// <summary>
        /// method that return the height of the image.
        /// </summary>
        public int getHeight();
    }
}
