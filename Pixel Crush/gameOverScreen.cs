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
    public partial class gameOverScreen : UserControl
    {
        public gameOverScreen()
        {
            InitializeComponent();
        }

        private void gameOverScreen_Load(object sender, EventArgs e)
        {
            if (GameScreen.playerWon)//if playerWon is true
            {
                titleLabel.Text = "Congratulations!";
                this.BackColor = Color.Purple;
            }
            else
            {
                titleLabel.Text = "GAMEOVER";
                this.BackColor = Color.Red;
            }
        }

        private void startOverButton_Click(object sender, EventArgs e)
        {
            StartScreen ss = new StartScreen();
            Form f = this.FindForm();
            f.Controls.Add(ss);
            f.Controls.Remove(this);
        }
    }
}
