namespace FlappyBirdReal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.DownPipe2 = new System.Windows.Forms.PictureBox();
            this.DownPipe = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.UpPipe = new System.Windows.Forms.PictureBox();
            this.UpPipe2 = new System.Windows.Forms.PictureBox();
            this.BestScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpPipe2)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Tag = "GameTimer";
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(63, 494);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(115, 31);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score: 0";
            // 
            // DownPipe2
            // 
            this.DownPipe2.Image = global::FlappyBirdReal.Properties.Resources.pipedown;
            this.DownPipe2.Location = new System.Drawing.Point(612, -128);
            this.DownPipe2.Margin = new System.Windows.Forms.Padding(4);
            this.DownPipe2.Name = "DownPipe2";
            this.DownPipe2.Size = new System.Drawing.Size(73, 245);
            this.DownPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownPipe2.TabIndex = 5;
            this.DownPipe2.TabStop = false;
            this.DownPipe2.Tag = "DownPipe";
            // 
            // DownPipe
            // 
            this.DownPipe.Image = global::FlappyBirdReal.Properties.Resources.pipedown;
            this.DownPipe.Location = new System.Drawing.Point(348, -38);
            this.DownPipe.Margin = new System.Windows.Forms.Padding(4);
            this.DownPipe.Name = "DownPipe";
            this.DownPipe.Size = new System.Drawing.Size(73, 245);
            this.DownPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownPipe.TabIndex = 3;
            this.DownPipe.TabStop = false;
            this.DownPipe.Tag = "DownPipe";
            // 
            // Ground
            // 
            this.Ground.Image = global::FlappyBirdReal.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(0, 454);
            this.Ground.Margin = new System.Windows.Forms.Padding(4);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(703, 101);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 1;
            this.Ground.TabStop = false;
            this.Ground.Tag = "Ground";
            // 
            // Player
            // 
            this.Player.Image = global::FlappyBirdReal.Properties.Resources.bird;
            this.Player.Location = new System.Drawing.Point(47, 231);
            this.Player.Margin = new System.Windows.Forms.Padding(4);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(80, 60);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // UpPipe
            // 
            this.UpPipe.Image = global::FlappyBirdReal.Properties.Resources.pipe;
            this.UpPipe.Location = new System.Drawing.Point(364, 353);
            this.UpPipe.Margin = new System.Windows.Forms.Padding(4);
            this.UpPipe.Name = "UpPipe";
            this.UpPipe.Size = new System.Drawing.Size(73, 202);
            this.UpPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpPipe.TabIndex = 6;
            this.UpPipe.TabStop = false;
            this.UpPipe.Tag = "UpPipe";
            // 
            // UpPipe2
            // 
            this.UpPipe2.Image = global::FlappyBirdReal.Properties.Resources.pipe;
            this.UpPipe2.Location = new System.Drawing.Point(587, 289);
            this.UpPipe2.Margin = new System.Windows.Forms.Padding(4);
            this.UpPipe2.Name = "UpPipe2";
            this.UpPipe2.Size = new System.Drawing.Size(73, 202);
            this.UpPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpPipe2.TabIndex = 7;
            this.UpPipe2.TabStop = false;
            this.UpPipe2.Tag = "UpPipe";
            // 
            // BestScore
            // 
            this.BestScore.AutoSize = true;
            this.BestScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BestScore.Location = new System.Drawing.Point(475, 494);
            this.BestScore.Name = "BestScore";
            this.BestScore.Size = new System.Drawing.Size(177, 31);
            this.BestScore.TabIndex = 8;
            this.BestScore.Tag = "BestScore";
            this.BestScore.Text = "Best Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(701, 554);
            this.Controls.Add(this.BestScore);
            this.Controls.Add(this.DownPipe2);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.DownPipe);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.UpPipe);
            this.Controls.Add(this.UpPipe2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpPipe2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox DownPipe;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox DownPipe2;
        private System.Windows.Forms.PictureBox UpPipe;
        private System.Windows.Forms.PictureBox UpPipe2;
        private System.Windows.Forms.Label BestScore;
    }
}

