using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel_Crush
{
    public partial class GameScreen : UserControl
    {
        //variables
        int mouseX, mouseY, score;

        //brush
        SolidBrush pixelBrush;

        //box list
        public static List<Pixel> pixels = new List<Pixel>();

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            Pixel p = new Pixel(300, 100);

            pixels.Add(p);
            //randomize grid 1 to amount desired cubes, then have a grid corisponding to a set about of spaces. check if match, then set x, y to that grid spot
            //todo figure out how to randomly generate boxes in a grid with pixel spacing of 5

        }


        //game loop
        private void gameLoop_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Pixel p in pixels)
            {
                p.r = p.rand.Next(1, 256);
                p.g = p.rand.Next(1, 256);
                p.b = p.rand.Next(1, 256);

                pixelBrush = new SolidBrush(Color.FromArgb(p.r, p.g, p.b));

                e.Graphics.FillRectangle(pixelBrush, p.x, p.y, 50, 50);
            }   
        }
    }
}
