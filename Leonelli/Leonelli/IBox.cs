using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leonelli
{
    public interface IBox
    {
        string Name { get; set; }

        double XLoc { get; set; }

        double YLoc { get; set; }

        double YDir { get; set; }

        double XDir { get; set; }

        int Width { get; set; }

        int Height { get; set; }

        ImageLoader GetImage();

        void Move();


    }
}
