
namespace ICE_AGE
{
    partial class step8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(step8));
            this.pic_sun = new System.Windows.Forms.PictureBox();
            this.pic_moon = new System.Windows.Forms.PictureBox();
            this.pic_shah = new System.Windows.Forms.PictureBox();
            this.pic_da = new System.Windows.Forms.PictureBox();
            this.lab_info = new System.Windows.Forms.Label();
            this.pic_ex = new System.Windows.Forms.PictureBox();
            this.pic_ex2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_shah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_da)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ex2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_sun
            // 
            this.pic_sun.BackColor = System.Drawing.Color.Transparent;
            this.pic_sun.Image = ((System.Drawing.Image)(resources.GetObject("pic_sun.Image")));
            this.pic_sun.Location = new System.Drawing.Point(295, 12);
            this.pic_sun.Name = "pic_sun";
            this.pic_sun.Size = new System.Drawing.Size(142, 122);
            this.pic_sun.TabIndex = 0;
            this.pic_sun.TabStop = false;
            // 
            // pic_moon
            // 
            this.pic_moon.BackColor = System.Drawing.Color.Transparent;
            this.pic_moon.Image = ((System.Drawing.Image)(resources.GetObject("pic_moon.Image")));
            this.pic_moon.Location = new System.Drawing.Point(83, 12);
            this.pic_moon.Name = "pic_moon";
            this.pic_moon.Size = new System.Drawing.Size(126, 114);
            this.pic_moon.TabIndex = 1;
            this.pic_moon.TabStop = false;
            // 
            // pic_shah
            // 
            this.pic_shah.BackColor = System.Drawing.Color.Transparent;
            this.pic_shah.Image = ((System.Drawing.Image)(resources.GetObject("pic_shah.Image")));
            this.pic_shah.Location = new System.Drawing.Point(548, 20);
            this.pic_shah.Name = "pic_shah";
            this.pic_shah.Size = new System.Drawing.Size(130, 114);
            this.pic_shah.TabIndex = 2;
            this.pic_shah.TabStop = false;
            this.pic_shah.Click += new System.EventHandler(this.pic_shah_Click);
            // 
            // pic_da
            // 
            this.pic_da.BackColor = System.Drawing.Color.Transparent;
            this.pic_da.Image = ((System.Drawing.Image)(resources.GetObject("pic_da.Image")));
            this.pic_da.Location = new System.Drawing.Point(83, 208);
            this.pic_da.Name = "pic_da";
            this.pic_da.Size = new System.Drawing.Size(354, 172);
            this.pic_da.TabIndex = 3;
            this.pic_da.TabStop = false;
            // 
            // lab_info
            // 
            this.lab_info.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_info.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lab_info.Location = new System.Drawing.Point(3, 137);
            this.lab_info.Name = "lab_info";
            this.lab_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_info.Size = new System.Drawing.Size(482, 338);
            this.lab_info.TabIndex = 12;
            this.lab_info.Text = resources.GetString("lab_info.Text");
            // 
            // pic_ex
            // 
            this.pic_ex.BackColor = System.Drawing.Color.Transparent;
            this.pic_ex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_ex.BackgroundImage")));
            this.pic_ex.Image = ((System.Drawing.Image)(resources.GetObject("pic_ex.Image")));
            this.pic_ex.Location = new System.Drawing.Point(613, 403);
            this.pic_ex.Name = "pic_ex";
            this.pic_ex.Size = new System.Drawing.Size(65, 65);
            this.pic_ex.TabIndex = 13;
            this.pic_ex.TabStop = false;
            this.pic_ex.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_ex_MouseDown);
            this.pic_ex.MouseEnter += new System.EventHandler(this.pic_ex_MouseEnter);
            this.pic_ex.MouseLeave += new System.EventHandler(this.pic_ex_MouseLeave);
            // 
            // pic_ex2
            // 
            this.pic_ex2.BackColor = System.Drawing.Color.Transparent;
            this.pic_ex2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_ex2.BackgroundImage")));
            this.pic_ex2.Image = ((System.Drawing.Image)(resources.GetObject("pic_ex2.Image")));
            this.pic_ex2.Location = new System.Drawing.Point(613, 403);
            this.pic_ex2.Name = "pic_ex2";
            this.pic_ex2.Size = new System.Drawing.Size(65, 65);
            this.pic_ex2.TabIndex = 14;
            this.pic_ex2.TabStop = false;
            // 
            // step8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(690, 480);
            this.Controls.Add(this.pic_ex2);
            this.Controls.Add(this.pic_ex);
            this.Controls.Add(this.lab_info);
            this.Controls.Add(this.pic_da);
            this.Controls.Add(this.pic_shah);
            this.Controls.Add(this.pic_moon);
            this.Controls.Add(this.pic_sun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "step8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "step8";
            this.Load += new System.EventHandler(this.step8_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.step8_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic_sun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_shah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_da)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ex2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_sun;
        private System.Windows.Forms.PictureBox pic_moon;
        private System.Windows.Forms.PictureBox pic_shah;
        private System.Windows.Forms.PictureBox pic_da;
        private System.Windows.Forms.Label lab_info;
        private System.Windows.Forms.PictureBox pic_ex;
        private System.Windows.Forms.PictureBox pic_ex2;
    }
}