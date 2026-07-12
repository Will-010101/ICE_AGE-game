
namespace ICE_AGE
{
    partial class stpe4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stpe4));
            this.pic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.track = new System.Windows.Forms.TrackBar();
            this.pic_snake = new System.Windows.Forms.PictureBox();
            this.pic_1home = new System.Windows.Forms.PictureBox();
            this.pic_2home = new System.Windows.Forms.PictureBox();
            this.lab_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_snake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2home)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(521, 238);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(141, 103);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(63, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 176);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // track
            // 
            this.track.Location = new System.Drawing.Point(30, 417);
            this.track.Maximum = 100;
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(632, 45);
            this.track.TabIndex = 2;
            this.track.Value = 5;
            this.track.Scroll += new System.EventHandler(this.track_Scroll);
            // 
            // pic_snake
            // 
            this.pic_snake.BackColor = System.Drawing.Color.Transparent;
            this.pic_snake.Image = ((System.Drawing.Image)(resources.GetObject("pic_snake.Image")));
            this.pic_snake.Location = new System.Drawing.Point(30, 161);
            this.pic_snake.Name = "pic_snake";
            this.pic_snake.Size = new System.Drawing.Size(648, 250);
            this.pic_snake.TabIndex = 3;
            this.pic_snake.TabStop = false;
            // 
            // pic_1home
            // 
            this.pic_1home.BackColor = System.Drawing.Color.Transparent;
            this.pic_1home.Image = ((System.Drawing.Image)(resources.GetObject("pic_1home.Image")));
            this.pic_1home.Location = new System.Drawing.Point(12, 12);
            this.pic_1home.Name = "pic_1home";
            this.pic_1home.Size = new System.Drawing.Size(65, 68);
            this.pic_1home.TabIndex = 6;
            this.pic_1home.TabStop = false;
            this.pic_1home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_1home_MouseDown_1);
            this.pic_1home.MouseEnter += new System.EventHandler(this.pic_1home_MouseEnter_1);
            this.pic_1home.MouseLeave += new System.EventHandler(this.pic_1home_MouseLeave_1);
            // 
            // pic_2home
            // 
            this.pic_2home.BackColor = System.Drawing.Color.Transparent;
            this.pic_2home.Image = ((System.Drawing.Image)(resources.GetObject("pic_2home.Image")));
            this.pic_2home.Location = new System.Drawing.Point(11, 13);
            this.pic_2home.Name = "pic_2home";
            this.pic_2home.Size = new System.Drawing.Size(66, 67);
            this.pic_2home.TabIndex = 7;
            this.pic_2home.TabStop = false;
            // 
            // lab_info
            // 
            this.lab_info.BackColor = System.Drawing.Color.Indigo;
            this.lab_info.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_info.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lab_info.Location = new System.Drawing.Point(224, 12);
            this.lab_info.Name = "lab_info";
            this.lab_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_info.Size = new System.Drawing.Size(487, 158);
            this.lab_info.TabIndex = 12;
            this.lab_info.Text = resources.GetString("lab_info.Text");
            // 
            // stpe4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(690, 480);
            this.Controls.Add(this.lab_info);
            this.Controls.Add(this.pic_2home);
            this.Controls.Add(this.pic_1home);
            this.Controls.Add(this.pic_snake);
            this.Controls.Add(this.track);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stpe4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stpe4";
            this.Load += new System.EventHandler(this.stpe4_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stpe4_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_snake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar track;
        private System.Windows.Forms.PictureBox pic_snake;
        private System.Windows.Forms.PictureBox pic_1home;
        private System.Windows.Forms.PictureBox pic_2home;
        private System.Windows.Forms.Label lab_info;
    }
}