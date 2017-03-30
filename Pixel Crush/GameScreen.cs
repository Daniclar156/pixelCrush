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

        //graphics objects
        SolidBrush pixelBrush;
        Pen selectionPen = new Pen(Color.Black);

        //box list
        public static List<Pixel> pixels = new List<Pixel>();

        //playing grid
        // public static List<int> pGrid = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });

        public GameScreen()
        {
            InitializeComponent();
            StartGame();
        }

        public void StartGame()
        {
            generateGrid();
        }
        /// <summary>
        /// Randomize grid of 12 cubes with random colors
        /// </summary>
        public void generateGrid()
        {
            //todo figure out color randomization

            Pixel p = new Pixel(275, 50);
            pixels.Add(p);

            Pixel p1 = new Pixel(375, 50);
            pixels.Add(p1);

            Pixel p2 = new Pixel(475, 50);
            pixels.Add(p2);

            Pixel p3 = new Pixel(575, 50);
            pixels.Add(p3);

            Pixel p4 = new Pixel(275, 125);
            pixels.Add(p4);

            Pixel p5 = new Pixel(375, 125);
            pixels.Add(p5);

            Pixel p6 = new Pixel(475, 125);
            pixels.Add(p6);

            Pixel p7 = new Pixel(575, 125);
            pixels.Add(p7);

            Pixel p8 = new Pixel(275, 200);
            pixels.Add(p8);

            Pixel p9 = new Pixel(375, 200);
            pixels.Add(p9);

            Pixel p10 = new Pixel(475, 200);
            pixels.Add(p10);

            Pixel p11 = new Pixel(575, 200);    
            pixels.Add(p11);

            //todo switch to playmode for player
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
