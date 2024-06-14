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
using NAudio.Wave;


namespace FlappyBirdReal
{
    public partial class Form1 : Form

    {
        private int gravity = 12 ;
        private int pipeSpeed = 17;
        public double score = 0;
        private double BestScore1 = 0;

        Random random = new Random();
        Random pipePosition = new Random();
        public Form1()
        {
            InitializeComponent();

            
        }
        private void PlaySound(string filePath, float volume)
        {
            var waveOut = new WaveOutEvent();
            var audioFileReader = new AudioFileReader(filePath);
            {
                waveOut.Volume = volume; // Устанавливаем громкость
            }
            
            waveOut.Init(audioFileReader);
            waveOut.Play();

            waveOut.PlaybackStopped += (s, a) =>
            {
                waveOut.Dispose();
                audioFileReader.Dispose();
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            

            Player.Top += gravity;
            DownPipe.Left -= pipeSpeed;
            UpPipe.Left -= pipeSpeed;
            DownPipe2.Left -= pipeSpeed;
            UpPipe2.Left -= pipeSpeed;
            gravity += 15;


            //score system based on flying threw top pipes only
            if (UpPipe.Left < -1)
            {
                UpPipe.Left = 550;
                UpPipe.Top = 261 + pipePosition.Next(-10,40);
                score = score + 1;
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
                score = score + 1;
            }
            //output of score and best score
            if (BestScore1 < score)
            {
                BestScore1 = score;
            }
            BestScore.Text = "Best Score: " + BestScore1;
            Score.Text = "Score: "+ score.ToString();



            if (Player.Bounds.IntersectsWith(UpPipe.Bounds)
                || Player.Bounds.IntersectsWith(DownPipe.Bounds) 
                || Player.Bounds.IntersectsWith(Ground.Bounds) 
                || Player.Top < -1 
                || Player.Bounds.IntersectsWith(DownPipe2.Bounds) 
                || Player.Bounds.IntersectsWith(UpPipe2.Bounds))
            {
                //respawn code
                Player.Location = new Point(35, 177);
                DownPipe.Location = new Point(261, -31);
                UpPipe.Location = new Point(273, 287);
                DownPipe2.Location = new Point(459, -104);
                UpPipe2.Location = new Point(440, 235);
                score = 0;
                GameTimer.Stop();
                PlaySound("fall.wav", 0.2f);
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            //fly button
            GameTimer.Start();
            if (e.KeyCode == Keys.Space)
            {
                gravity = -17;
            }
            
            PlaySound("sfx_wing.wav", 0.2f);
        }
        private void gamekeyisup(object sender, KeyEventArgs e)
        {

        }
    }
}
