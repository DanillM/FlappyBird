using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdReal
{
    public partial class Form2 : Form
    {

        private int gravity = 12;
        private int pipeSpeed = 17;
        public double scoreScore = 0;

        Random random = new Random();
        Random pipePosition = new Random();
        public Form2()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(Player.Left);
            Debug.WriteLine(UpPipe.Left);

            Player.Top += gravity;
            DownPipe.Left -= pipeSpeed;
            UpPipe.Left -= pipeSpeed;
            DownPipe2.Left -= pipeSpeed;
            UpPipe2.Left -= pipeSpeed;
            gravity += 15;
            if (UpPipe.Left < -1)
            {
                UpPipe.Left = 550;
                UpPipe.Top = 261 + pipePosition.Next(-10, 40);
            }
            if (DownPipe.Left < -1)
            {
                DownPipe.Left = 550;
                DownPipe.Top = -52 + pipePosition.Next(-10, 40);
            }
            if (DownPipe2.Left < -1)
            {
                DownPipe2.Left = 550;
                DownPipe2.Top = -52 + pipePosition.Next(-10, 40);
            }
            if (UpPipe2.Left < -1)
            {
                UpPipe2.Left = 550;
                UpPipe2.Top = 261 + pipePosition.Next(-10, 40);
            }
            if (UpPipe.Left <= Player.Left)
            {
                scoreScore = scoreScore + 1;
            }
            Score.Text = "Score: " + scoreScore.ToString();






            if (Player.Bounds.IntersectsWith(UpPipe.Bounds) || Player.Bounds.IntersectsWith(DownPipe.Bounds)
                || Player.Bounds.IntersectsWith(Ground.Bounds) || Player.Top < -1)
            {

                GameTimer.Stop();


                Player.Location = new Point(35, 177);
                DownPipe.Location = new Point(369, -52);
                UpPipe.Location = new Point(285, 261);
                scoreScore = 0;

                using (var soundPlayer = new SoundPlayer(Properties.Resources.fall))
                {
                    soundPlayer.Play();
                }
                scoreScore = 0;


            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            GameTimer.Start();
            if (e.KeyCode == Keys.Space)
            {
                gravity = -17;
            }
            using (var soundPlayer = new SoundPlayer(Properties.Resources.jump))
            {
                soundPlayer.Play();
            }

            //Player.Location = new Point(35, 177);
            //DownPipe.Location = new Point(369, 0);
            //UpPipe.Location = new Point(287, 266);
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {




        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void Difficulty_Click(object sender, EventArgs e)
        {

            

        }
    }
}
