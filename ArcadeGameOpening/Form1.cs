using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace ArcadeGameOpening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void PlayGame_MouseHover(object sender, EventArgs e)
        {
            PlayButton.ForeColor = Color.Red;
        
        }

        private void PlayGame_MouseLeave(object sender, EventArgs e)
        {
            PlayButton.ForeColor = Color.White;
        }

        private void PlayGame_Click(object sender, EventArgs e)
        {
            Refresh();

            PlayButton.Text = "Alright";

            SoundPlayer alertplayer = new SoundPlayer(Properties.Resources.gameCube);
            alertplayer.Play();

            Refresh();
            Thread.Sleep(500);

            PlayButton.Text = "Starting .";

            Refresh();
            Thread.Sleep(500);

            PlayButton.Text = "Starting . .";

            Refresh();
            Thread.Sleep(500);

            PlayButton.Text = "Starting . . .";

            Refresh();
            Thread.Sleep(500);

            PlayButton.Text = "Starting .";

            Refresh();
            Thread.Sleep(500);

            PlayButton.Text = "Starting . .";

            Refresh();
            Thread.Sleep(500);

            PlayButton.Text = "Starting . . .";

            Refresh();
            Thread.Sleep(500);

            PlayButton.Text = "Starting .";

            Refresh();
            Thread.Sleep(500);

            PlayButton.Text = "Starting . .";

            Refresh();
            Thread.Sleep(500);

            PlayButton.Text = "Starting . . .";

            Refresh();
            Thread.Sleep(500);

            PlayButton.ForeColor = Color.White;
            PlayButton.Text = "Play !";

            Refresh();
            Thread.Sleep(500);

            PlayButton.Visible = false;

            

        }
    }
}
