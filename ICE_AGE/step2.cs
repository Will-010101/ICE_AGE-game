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
    public partial class step2 : Form
    {
        public step2()
        {
            InitializeComponent();
        }
        int select = 0;
        private void step2_Load(object sender, EventArgs e)
        {
            pic1.BorderStyle = BorderStyle.None;
            pic2.BorderStyle = BorderStyle.None;
            pic.Visible = false;
            lab_info.Visible = false;
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            pic1.BorderStyle = BorderStyle.FixedSingle;
            pic2.BorderStyle = BorderStyle.None;
            select = 1;
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            pic2.BorderStyle = BorderStyle.FixedSingle;
            pic1.BorderStyle = BorderStyle.None;
            select = 2;
        }
        int x = 0;
        private void enter()
        {
            if (x == 0)
            {
                pic1.Visible = false;
                pic2.Visible = false;
                lab_info.Visible = true;
                this.BackgroundImage = Properties.Resources.step2_2;
                StreamReader sr = File.OpenText("score");
                string score = sr.ReadLine();
                int score2 = Convert.ToInt16(score);
                sr.Close();
                if (score2 < 2)
                    File.WriteAllText("score", "2");
                MessageBox.Show("اگر میخواهید درباره مرحله پشت سر گذاشته اطلاعات داشته باشید پیام را با ضربدر ببندید وگرنه اینتر را بزنید 😁");

                x = 1;
            }
            else if(x==1)
            {
                this.Close();
            }
        }
        private void step2_KeyUp(object sender, KeyEventArgs e)
        {
            if (select == 1)
            {
                if (e.KeyCode.ToString() == "Down")
                    pic1.Location = new Point(pic1.Location.X, pic1.Location.Y + 10);
                if (e.KeyCode.ToString() == "Up")
                    pic1.Location = new Point(pic1.Location.X, pic1.Location.Y - 10);
                if (e.KeyCode.ToString() == "Right")
                    pic1.Location = new Point(pic1.Location.X + 10, pic1.Location.Y);
                if (e.KeyCode.ToString() == "Left")
                    pic1.Location = new Point(pic1.Location.X - 10, pic1.Location.Y);
                if (e.KeyCode.ToString() == "Return")
                {
                    if (pic1.Location.X < 200 && pic1.Location.X > 100 && pic2.Location.X > 320 && pic2.Location.X < 420)
                        enter();
                    else if (pic1.Location.X < 200 && pic1.Location.X > 100)
                            MessageBox.Show("😁پیام را با ضربدر ببندید");
                }
            }
            if (select == 2)
            {
                if (e.KeyCode.ToString() == "Down")
                    pic2.Location = new Point(pic2.Location.X, pic2.Location.Y + 10);
                if (e.KeyCode.ToString() == "Up")
                    pic2.Location = new Point(pic2.Location.X, pic2.Location.Y - 10);
                if (e.KeyCode.ToString() == "Right")
                    pic2.Location = new Point(pic2.Location.X + 10, pic2.Location.Y);
                if (e.KeyCode.ToString() == "Left")
                    pic2.Location = new Point(pic2.Location.X - 10, pic2.Location.Y);
                if (e.KeyCode.ToString() == "Return")
                {
                    if (pic1.Location.X < 200 && pic1.Location.X > 100 && pic2.Location.X > 320 && pic2.Location.X < 420)
                        enter();
                    else if (pic2.Location.X > 320 && pic2.Location.X < 420)
                        MessageBox.Show("😁پیام را با ضربدر ببندید");
                }
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pic.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pic.Visible = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
