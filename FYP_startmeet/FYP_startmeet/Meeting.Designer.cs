namespace FYP_startmeet
{
    partial class Meeting
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
            this.pbStop = new System.Windows.Forms.PictureBox();
            this.pbpause = new System.Windows.Forms.PictureBox();
            this.pbplay = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStop
            // 
            this.pbStop.Image = global::FYP_startmeet.Properties.Resources.stop1;
            this.pbStop.Location = new System.Drawing.Point(800, 620);
            this.pbStop.Name = "pbStop";
            this.pbStop.Size = new System.Drawing.Size(74, 72);
            this.pbStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStop.TabIndex = 11;
            this.pbStop.TabStop = false;
            // 
            // pbpause
            // 
            this.pbpause.Image = global::FYP_startmeet.Properties.Resources.pause1;
            this.pbpause.Location = new System.Drawing.Point(673, 620);
            this.pbpause.Name = "pbpause";
            this.pbpause.Size = new System.Drawing.Size(74, 72);
            this.pbpause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpause.TabIndex = 10;
            this.pbpause.TabStop = false;
            // 
            // pbplay
            // 
            this.pbplay.Image = global::FYP_startmeet.Properties.Resources.play;
            this.pbplay.Location = new System.Drawing.Point(546, 620);
            this.pbplay.Name = "pbplay";
            this.pbplay.Size = new System.Drawing.Size(74, 72);
            this.pbplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbplay.TabIndex = 9;
            this.pbplay.TabStop = false;
            this.pbplay.Click += new System.EventHandler(this.pbplay_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBox2.Image = global::FYP_startmeet.Properties.Resources.animation_41;
            this.pictureBox2.Location = new System.Drawing.Point(75, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(611, 413);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1382, 782);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Meeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.pbStop);
            this.Controls.Add(this.pbpause);
            this.Controls.Add(this.pbplay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Meeting";
            this.Text = "Meeting";
            this.Load += new System.EventHandler(this.Meeting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbplay;
        private System.Windows.Forms.PictureBox pbpause;
        private System.Windows.Forms.PictureBox pbStop;
    }
}