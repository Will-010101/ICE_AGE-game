using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Resources;

namespace ICE_AGE
{
    public partial class step7 : Form
    {
        public step7()
        {
            InitializeComponent();
        }

        private void step7_Load(object sender, EventArgs e)
        {
            pic_1.Visible = false;
            pic_2.Visible = false;
            pic_3.Visible = false;
            pic_4.Visible = false;
            pic_5.Visible = false;
            pic_ex2.Visible = false;
            lab_info.Visible = false;
        }
        int x = 0;
        private void step7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return" && x == 1)
            {
                this.Close();
            }
            else if (pic1.Location.X>540 && pic1.Location.X < 580 && pic1.Location.Y>230 && pic1.Location.Y < 270)
            {
                pic_1.Visible = true;
                pic_2.Visible = true;
                pic_3.Visible = true;
                pic_4.Visible = true;
                pic_5.Visible = true;
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                lab_info.Visible = true;
                StreamReader sr = File.OpenText("score");
                string score = sr.ReadLine();
                int score2 = Convert.ToInt16(score);
                sr.Close();
                if (score2 < 7)
                    File.WriteAllText("score", "7");
                MessageBox.Show("اگر میخواهید درباره مرحله پشت سر گذاشته اطلاعات داشته باشید پیام را با ضربدر ببندید وگرنه اینتر را بزنید 😁");

                x = 1;
            }
            if (e.KeyCode.ToString() == "Down")
                pic1.Location = new Point(pic1.Location.X, pic1.Location.Y + 10);
            if (e.KeyCode.ToString() == "Up")
                pic1.Location = new Point(pic1.Location.X, pic1.Location.Y - 10);
            if (e.KeyCode.ToString() == "Right")
                pic1.Location = new Point(pic1.Location.X + 10, pic1.Location.Y);
            if (e.KeyCode.ToString() == "Left")
                pic1.Location = new Point(pic1.Location.X - 10, pic1.Location.Y);
        }

        private void pic_ex_MouseEnter(object sender, EventArgs e)
        {
            pic_ex2.Visible = true;
        }

        private void pic_ex_MouseLeave(object sender, EventArgs e)
        {
            pic_ex2.Visible = false;
        }

        private void pic_ex_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
