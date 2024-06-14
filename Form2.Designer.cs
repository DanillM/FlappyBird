namespace FlappyBirdReal
{
    partial class Form2
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.DownPipe = new System.Windows.Forms.PictureBox();
            this.UpPipe = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DownPipe2 = new System.Windows.Forms.PictureBox();
            this.UpPipe2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpPipe2)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Image = global::FlappyBirdReal.Properties.Resources.bird;
            this.Player.Location = new System.Drawing.Point(43, 200);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(60, 49);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // DownPipe
            // 
            this.DownPipe.Image = global::FlappyBirdReal.Properties.Resources.pipedown;
            this.DownPipe.Location = new System.Drawing.Point(333, -12);
            this.DownPipe.Name = "DownPipe";
            this.DownPipe.Size = new System.Drawing.Size(55, 156);
            this.DownPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownPipe.TabIndex = 4;
            this.DownPipe.TabStop = false;
            this.DownPipe.Tag = "DownPipe";
            // 
            // UpPipe
            // 
            this.UpPipe.Image = global::FlappyBirdReal.Properties.Resources.pipe;
            this.UpPipe.Location = new System.Drawing.Point(282, 298);
            this.UpPipe.Name = "UpPipe";
            this.UpPipe.Size = new System.Drawing.Size(55, 164);
            this.UpPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpPipe.TabIndex = 7;
            this.UpPipe.TabStop = false;
            this.UpPipe.Tag = "UpPipe";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(53, 383);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(92, 25);
            this.Score.TabIndex = 8;
            this.Score.Text = "Score: 0";
            // 
            // Ground
            // 
            this.Ground.Image = global::FlappyBirdReal.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(0, 369);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(527, 82);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 9;
            this.Ground.TabStop = false;
            this.Ground.Tag = "Ground";
            // 
            // GameTimer
            // 
            this.GameTimer.Tag = "GameTimer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Score: 0";
            // 
            // DownPipe2
            // 
            this.DownPipe2.Image = global::FlappyBirdReal.Properties.Resources.pipedown;
            this.DownPipe2.Location = new System.Drawing.Point(459, -64);
            this.DownPipe2.Name = "DownPipe2";
            this.DownPipe2.Size = new System.Drawing.Size(55, 199);
            this.DownPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownPipe2.TabIndex = 12;
            this.DownPipe2.TabStop = false;
            this.DownPipe2.Tag = "DownPipe";
            // 
            // UpPipe2
            // 
            this.UpPipe2.Image = global::FlappyBirdReal.Properties.Resources.pipe;
            this.UpPipe2.Location = new System.Drawing.Point(414, 242);
            this.UpPipe2.Name = "UpPipe2";
            this.UpPipe2.Size = new System.Drawing.Size(55, 164);
            this.UpPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpPipe2.TabIndex = 13;
            this.UpPipe2.TabStop = false;
            this.UpPipe2.Tag = "UpPipe2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.DownPipe2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.UpPipe);
            this.Controls.Add(this.DownPipe);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.UpPipe2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpPipe2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox DownPipe;
        private System.Windows.Forms.PictureBox UpPipe;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox DownPipe2;
        private System.Windows.Forms.PictureBox UpPipe2;
    }
}