﻿namespace SaveTheCoffeeBeans
{
    partial class HardLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardLevel));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.life = new System.Windows.Forms.Label();
            this.bagsdropped = new System.Windows.Forms.Label();
            this.flowersdropped = new System.Windows.Forms.Label();
            this.bagscatched = new System.Windows.Forms.Label();
            this.flowerscatched = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SaveTheCoffeeBeans.Properties.Resources.anvil;
            this.pictureBox5.Location = new System.Drawing.Point(501, 99);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Anvil";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(378, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Flowers";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(249, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Flowers";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SaveTheCoffeeBeans.Properties.Resources.Sack2_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(130, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Sacks";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaveTheCoffeeBeans.Properties.Resources.Sack1_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Sacks";
            // 
            // player
            // 
            this.player.Image = global::SaveTheCoffeeBeans.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(249, 612);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(93, 83);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // life
            // 
            this.life.AutoSize = true;
            this.life.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.life.Location = new System.Drawing.Point(267, 20);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(55, 18);
            this.life.TabIndex = 6;
            this.life.Text = "Lifes: 3";
            // 
            // bagsdropped
            // 
            this.bagsdropped.AutoSize = true;
            this.bagsdropped.Location = new System.Drawing.Point(494, 20);
            this.bagsdropped.Name = "bagsdropped";
            this.bagsdropped.Size = new System.Drawing.Size(104, 17);
            this.bagsdropped.TabIndex = 10;
            this.bagsdropped.Text = "Bags Missed: 0";
            // 
            // flowersdropped
            // 
            this.flowersdropped.AutoSize = true;
            this.flowersdropped.Location = new System.Drawing.Point(352, 20);
            this.flowersdropped.Name = "flowersdropped";
            this.flowersdropped.Size = new System.Drawing.Size(120, 17);
            this.flowersdropped.TabIndex = 9;
            this.flowersdropped.Text = "Flowers Missed: 0";
            // 
            // bagscatched
            // 
            this.bagscatched.AutoSize = true;
            this.bagscatched.Location = new System.Drawing.Point(147, 20);
            this.bagscatched.Name = "bagscatched";
            this.bagscatched.Size = new System.Drawing.Size(105, 17);
            this.bagscatched.TabIndex = 8;
            this.bagscatched.Text = "Bags Caught: 0";
            // 
            // flowerscatched
            // 
            this.flowerscatched.AutoSize = true;
            this.flowerscatched.Location = new System.Drawing.Point(0, 20);
            this.flowerscatched.Name = "flowerscatched";
            this.flowerscatched.Size = new System.Drawing.Size(121, 17);
            this.flowerscatched.TabIndex = 7;
            this.flowerscatched.Text = "Flowers Caught: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTick);
            // 
            // HardLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 694);
            this.Controls.Add(this.bagsdropped);
            this.Controls.Add(this.flowersdropped);
            this.Controls.Add(this.bagscatched);
            this.Controls.Add(this.flowerscatched);
            this.Controls.Add(this.life);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HardLevel";
            this.Text = "Hard";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.iskeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.iskeyup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label life;
        private System.Windows.Forms.Label bagsdropped;
        private System.Windows.Forms.Label flowersdropped;
        private System.Windows.Forms.Label bagscatched;
        private System.Windows.Forms.Label flowerscatched;
        private System.Windows.Forms.Timer gameTimer;
    }
}