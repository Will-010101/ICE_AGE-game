
namespace ICE_AGE
{
    partial class step10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(step10));
            this.pic = new System.Windows.Forms.PictureBox();
            this.pic_ch = new System.Windows.Forms.PictureBox();
            this.pic_home = new System.Windows.Forms.PictureBox();
            this.lab_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(40, 124);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(177, 262);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // pic_ch
            // 
            this.pic_ch.BackColor = System.Drawing.Color.Transparent;
            this.pic_ch.Image = ((System.Drawing.Image)(resources.GetObject("pic_ch.Image")));
            this.pic_ch.Location = new System.Drawing.Point(171, 275);
            this.pic_ch.Name = "pic_ch";
            this.pic_ch.Size = new System.Drawing.Size(263, 135);
            this.pic_ch.TabIndex = 1;
            this.pic_ch.TabStop = false;
            this.pic_ch.Click += new System.EventHandler(this.pic_ch_Click);
            // 
            // pic_home
            // 
            this.pic_home.BackColor = System.Drawing.Color.Transparent;
            this.pic_home.Image = ((System.Drawing.Image)(resources.GetObject("pic_home.Image")));
            this.pic_home.Location = new System.Drawing.Point(485, 163);
            this.pic_home.Name = "pic_home";
            this.pic_home.Size = new System.Drawing.Size(220, 223);
            this.pic_home.TabIndex = 2;
            this.pic_home.TabStop = false;
            // 
            // lab_info
            // 
            this.lab_info.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_info.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lab_info.Location = new System.Drawing.Point(205, 9);
            this.lab_info.Name = "lab_info";
            this.lab_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_info.Size = new System.Drawing.Size(482, 148);
            this.lab_info.TabIndex = 12;
            this.lab_info.Text = resources.GetString("lab_info.Text");
            // 
            // step10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(690, 480);
            this.Controls.Add(this.lab_info);
            this.Controls.Add(this.pic_home);
            this.Controls.Add(this.pic_ch);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "step10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "step10";
            this.Load += new System.EventHandler(this.step10_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.step10_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.PictureBox pic_ch;
        private System.Windows.Forms.PictureBox pic_home;
        private System.Windows.Forms.Label lab_info;
    }
}