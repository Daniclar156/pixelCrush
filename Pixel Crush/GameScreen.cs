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
        int score;

        //graphics objects
        SolidBrush pixelBrush;
        Pen selectionPen = new Pen(Color.Black);

        //box list
        public static List<Pixel> pixels = new List<Pixel>();

        Random randGen = new Random();

        string lastColor = "nothing";

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

            foreach (Pixel pp in pixels)
            {
                int c = randGen.Next(1, 4);
                pp.generateColor(c);
            }
        }

        private void GameScreen_MouseDown(object sender, MouseEventArgs e)
        {
            Form f = this.FindForm();
            int temp = f.Location.X;
            //player turn
            foreach (Pixel p in pixels)
            {//make sure a pixel is selected and the same color
                p.selected = false;
                if (p.PixelClicked(p, MousePosition.X - f.Location.X, MousePosition.Y - f.Location.Y))
                {
                    
                    //if last was red
                    if ((lastColor == "red" && p.r == 255) || lastColor == "nothing")
                    {
                        selectionPen.Width = 3;
                        Graphics g = this.CreateGraphics();
                        g.DrawRectangle(selectionPen, p.x - 5, p.y - 5, 60, 60);
                        p.selected = true;
                    }

                    //if last was green
                    if (lastColor == "green" && p.g == 255)
                    {
                        selectionPen.Width = 3;
                        Graphics g = this.CreateGraphics();
                        g.DrawRectangle(selectionPen, p.x - 5, p.y - 5, 60, 60);
                        p.selected = true;
                    }

                    //if last was blue
                    if (lastColor == "blue" && p.b == 255)
                    {
                        selectionPen.Width = 3;
                        Graphics g = this.CreateGraphics();
                        g.DrawRectangle(selectionPen, p.x - 5, p.y - 5, 60, 60);
                        p.selected = true;
                    }

                    if (p.r == 255)
                    {
                        lastColor = "red";
                    }
                    else if (p.g == 255)
                    {
                        lastColor = "green";
                    }
                    else
                    {
                        lastColor = "blue";
                    }
                   
                }
            }
           //Refresh();
        }

        private void checkSelected_Click(object sender, EventArgs e)
        {
            foreach(Pixel p in pixels)
            {
                if (p.selected == true)
                {
                    if(p.r == 255 && p.g == 0 && p.b == 0)
                    {
                        pixels.Remove(p);
                        Refresh();
                    }
                }
            }
        }


        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Pixel p in pixels)
            {
                pixelBrush = new SolidBrush(Color.FromArgb(p.r, p.g, p.b));

                e.Graphics.FillRectangle(pixelBrush, p.x, p.y, 50, 50);
            }
        }
    }
}
