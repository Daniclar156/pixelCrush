using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel_Crush
{
    public class Pixel
    {
        public int r, g, b, x, y;

        public Random rand = new Random();

        public Pixel (int _x, int _y, int _r, int _g, int _b)
        {
            x = _x;
            y = _y;

            //todo make sure boxes dont paint on each other
        }

        public void checkMouse(int mouseX, int mouseY)
        {//todo check .intersecs with my drawing rectangle where mouse click.

        }
    }
}
