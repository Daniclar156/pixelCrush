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

        //randomizer
        Random randPos = new Random();

        //brush
        SolidBrush pixelBrush;

        //box list
        public static List<Pixel> pixels = new List<Pixel>();

        //playing grid
       // public static List<int> pGrid = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            generateGrid();
            //randomize grid 1 to amount desired cubes, then have a grid corisponding to a set about of spaces. check if match, then set x, y to that grid spot
            //todo figure out how to randomly generate boxes in a grid with pixel spacing of 5
        }

        public void generateGrid()
        {
            foreach (Pixel p in pixels)
            {
                int boxPos = 1;//randPos.Next(1, 13);
                switch (boxPos)
                {
                    case 1:
                        Pixel pp = new Pixel(100, 100);
                        pixels.Add(pp);
                        break;
                }
            }
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
