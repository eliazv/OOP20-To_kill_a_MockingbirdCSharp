using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Maffi
{
    public interface Box
    {
        /// <summary>
        /// Set an image (via filename) for the specified box.
        /// <param name="filename"> the filename of the image
        void SetImage(String filename);

        /// <summary>
        /// Returns the image of the specified box.
        /// @return an imageLoader

        ImageLoader GetImage();

        /// <summary>
        /// Returns the name of the specified box.
        /// <returns> get the Name
        String GetName { get; }

        /// <summary>
        /// Property that allow to set and return the value of X location
        /// <returns> get the Xloc
        double XLoc { get; set; }

        /// <summary>
        /// Property that allow to set and return the value of Y location
        /// <returns> get the Yloc
        double YLoc { get; set; }

        /// <summary>
        /// Property that allow to set and return the value of X direction
        /// <returns> get the XDir
        double XDir { get; set; }

        /// <summary>
        /// Property that allow to set and return the value of Y direction
        /// <returns> get the YDir
        double YDir { get; set; }

        /// <summary>
        /// Property that return the width of the image.
        /// <returns> get the width
        int GetWidth { get; }

        /// <summary>
        /// Property that return the height of the image.
        /// <returns> get the height
        int GetHeight { get; }

        /// <summary>
        /// Method that paints the boxes in the jpanel.
        /// <param name="g"> g allow an application to draw onto components
        /// <param name="panel"> panel is the jpanel where the boxes will be painted
        void Paint(Graphics g, Panel panel);

        /// <summary>
        /// method that allow to move the boxes by increasing the position with the direction
        void Move();
    }
}
