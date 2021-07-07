using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavatta
{
    public interface IStrip
    {

        /// <summary>
        /// Generate an array of 8 box with a random environment among the three total.
        /// <param name="y"> contains the line where the array will be printed</param>
        /// <returns> get an array of 8 box
        IList<Box> InitializeRndStrip(int y);

        /// <summary>
        /// returns a box that can be an obstacle once in four.
        /// <param name="background">   contains the environment</param>
        /// <param name="specialBlock"> contains the obstacle which could be printed</param>
        /// <param name="x">            is the position within the vector of the strip</param>
        /// <param name="y">           contains the line where the array will be printed</param>
        /// <returns> get a box
        Box InsertBoxObstacles(string background, string specialBlock, int x, int y);

        /// <summary>
        ///returns a specific environment strip.
        /// <param name="background"> contains the environment of the desired strip</param>
        /// <param name="y">          contains the line where the array will be printed</param>
        /// <returns> get an array of 8 box
        IList<Box> InitializeSpecificStrip(string background, int y);

        /// <summary>
        /// returns a specific environment strip with specific obstacles. useful for
        ///creating the initial area
        /// <param name="background">   contains the environment of the desired strip</param>
        /// <param name="specialBlock"> contains the obstacle of the desired strip</param>
        /// <param name="y">            contains the line where the array will be printed</param>
        /// <returns> get an array of 8 box
        IList<Box> InitializeSpecificStrip(string background, string specialBlock, int y);

        /// <summary>
        /// returns the generated strip.
        /// <returns> get an array of 8 box
        IList<Box> GetStrip { get; }

        /// <summary>
        /// returns the box of the strip specified by the index.
        /// <param name="x"> strip vector index</param>
        /// <returns> get a box
        Box GetBoxOfStrip(int x);

        /// <summary>
        /// returns the environment type of the Strip.
        /// <returns> get the environment type of the Strip
        StripEnvironment GetStripEnvironment { get; }

        /// <summary>
        /// set the environment type of the Strip.
        /// <param name="background"> strip background</param>
        void SetStripEnvironment(string background);

    }
}
