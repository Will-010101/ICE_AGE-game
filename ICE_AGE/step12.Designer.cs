
namespace ICE_AGE
{
    partial class step12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(step12));
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.lab_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Transparent;
            this.pic1.Location = new System.Drawing.Point(170, 227);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(64, 47);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            this.pic2.Location = new System.Drawing.Point(277, 128);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(71, 61);
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // lab_info
            // 
            this.lab_info.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_info.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lab_info.Location = new System.Drawing.Point(106, 324);
            this.lab_info.Name = "lab_info";
            this.lab_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lab_info.Size = new System.Drawing.Size(482, 158);
            this.lab_info.TabIndex = 12;
            this.lab_info.Text = "تبریککککک!!!\r\nشما بازی را به پایان رساندید و در طی این بازی با روند تکامل بشر و م" +
    "وجودات مختلف اشنا شدید😆\r\nامیدواریم از بازی لذت برده باشید😍\r\nبرای رفتن به خانه " +
    "اینتر را بزنید";
            // 
            // step12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(690, 480);
            this.Controls.Add(this.lab_info);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "step12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "step12";
            this.Load += new System.EventHandler(this.step12_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.step12_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label lab_info;
    }
}