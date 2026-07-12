
namespace ICE_AGE
{
    partial class step11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(step11));
            this.pic_lab1 = new System.Windows.Forms.PictureBox();
            this.pic_lab2 = new System.Windows.Forms.PictureBox();
            this.pic_led1 = new System.Windows.Forms.PictureBox();
            this.pic_led2 = new System.Windows.Forms.PictureBox();
            this.lab_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lab2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_led1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_led2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_lab1
            // 
            this.pic_lab1.BackColor = System.Drawing.Color.Transparent;
            this.pic_lab1.Image = ((System.Drawing.Image)(resources.GetObject("pic_lab1.Image")));
            this.pic_lab1.Location = new System.Drawing.Point(160, 45);
            this.pic_lab1.Name = "pic_lab1";
            this.pic_lab1.Size = new System.Drawing.Size(115, 134);
            this.pic_lab1.TabIndex = 0;
            this.pic_lab1.TabStop = false;
            // 
            // pic_lab2
            // 
            this.pic_lab2.BackColor = System.Drawing.Color.Transparent;
            this.pic_lab2.Image = ((System.Drawing.Image)(resources.GetObject("pic_lab2.Image")));
            this.pic_lab2.Location = new System.Drawing.Point(160, 45);
            this.pic_lab2.Name = "pic_lab2";
            this.pic_lab2.Size = new System.Drawing.Size(115, 134);
            this.pic_lab2.TabIndex = 1;
            this.pic_lab2.TabStop = false;
            // 
            // pic_led1
            // 
            this.pic_led1.BackColor = System.Drawing.Color.Transparent;
            this.pic_led1.Image = ((System.Drawing.Image)(resources.GetObject("pic_led1.Image")));
            this.pic_led1.Location = new System.Drawing.Point(87, 123);
            this.pic_led1.Name = "pic_led1";
            this.pic_led1.Size = new System.Drawing.Size(67, 98);
            this.pic_led1.TabIndex = 2;
            this.pic_led1.TabStop = false;
            this.pic_led1.Click += new System.EventHandler(this.pic_led1_Click);
            // 
            // pic_led2
            // 
            this.pic_led2.BackColor = System.Drawing.Color.Transparent;
            this.pic_led2.Image = ((System.Drawing.Image)(resources.GetObject("pic_led2.Image")));
            this.pic_led2.Location = new System.Drawing.Point(81, 103);
            this.pic_led2.Name = "pic_led2";
            this.pic_led2.Size = new System.Drawing.Size(74, 118);
            this.pic_led2.TabIndex = 3;
            this.pic_led2.TabStop = false;
            // 
            // lab_info
            // 
            this.lab_info.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_info.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lab_info.Location = new System.Drawing.Point(0, 319);
            this.lab_info.Name = "lab_info";
            this.lab_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_info.Size = new System.Drawing.Size(482, 162);
            this.lab_info.TabIndex = 12;
            this.lab_info.Text = resources.GetString("lab_info.Text");
            // 
            // step11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(690, 480);
            this.Controls.Add(this.lab_info);
            this.Controls.Add(this.pic_led2);
            this.Controls.Add(this.pic_led1);
            this.Controls.Add(this.pic_lab2);
            this.Controls.Add(this.pic_lab1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "step11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "step11";
            this.Load += new System.EventHandler(this.step11_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.step11_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic_lab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lab2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_led1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_led2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_lab1;
        private System.Windows.Forms.PictureBox pic_lab2;
        private System.Windows.Forms.PictureBox pic_led1;
        private System.Windows.Forms.PictureBox pic_led2;
        private System.Windows.Forms.Label lab_info;
    }
}