using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pixel_Crush
{
    public class Pixel
    {
        public int r, g, b, x, y;

        public bool redSelected = false;
        public bool greenSelected = false;
        public bool blueSelected = false;

        public Pixel(int _x, int _y)
        {
            r = g = b = 0;
            x = _x;
            y = _y;

        }

        /// <summary>
        /// generates the color of each pixel
        /// </summary>
        public void generateColor(int pColor)
        {
            if (pColor == 1)
            {
                r = 255;
                g = 0;
                b = 0;
            }
            if (pColor == 2)
            {
                r = 0;
                g = 255;
                b = 0;
            }
            if (pColor == 3)
            {
                r = 0;
                g = 0;
                b = 255;           
            }
        }

        /// <summary>
        /// Runs the players turn, Checks if mouse intersecs with rectangle
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Boolean PixelClicked(Pixel p, int mouseX, int mouseY)
        {//check .intersecs with by drawing rectangle where mouse click.

            Rectangle pixelRec = new Rectangle(p.x, p.y, 50, 50);
            Rectangle mouseRec = new Rectangle(mouseX, mouseY, 1, 1);

            return pixelRec.IntersectsWith(mouseRec);
        }
    }
}
