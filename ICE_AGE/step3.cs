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
    public partial class step3 : Form
    {
        public step3()
        {
            InitializeComponent();
        }
        int select = 0;
        private void step3_Load(object sender, EventArgs e)
        {
            pic.Visible = false;
            pic_circle.BorderStyle = BorderStyle.None;
            pic_fish.BorderStyle = BorderStyle.None;
            pic_m.Visible = false;
            lab_info.Visible = false;
        }
        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pic.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pic.Visible = false;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pic_circle_Click(object sender, EventArgs e)
        {
            select = 1;
            pic_circle.BorderStyle = BorderStyle.FixedSingle;
            pic_fish.BorderStyle = BorderStyle.None;
        }

        private void pic_fish_Click(object sender, EventArgs e)
        {
            select = 2;
            pic_circle.BorderStyle = BorderStyle.None;
            pic_fish.BorderStyle = BorderStyle.FixedSingle;
        }
        int x = 0;
        private void enter()
        {
            if (x == 0)
            {
                pic_circle.Visible = false;
                pic_fish.Visible = false;
                pic_m.Visible = true;
                lab_info.Visible = true;
                StreamReader sr = File.OpenText("score");
                string score = sr.ReadLine();
                int score2 = Convert.ToInt16(score);
                sr.Close();
                if (score2 < 3)
                    File.WriteAllText("score", "3");
                MessageBox.Show("اگر میخواهید درباره مرحله پشت سر گذاشته اطلاعات داشته باشید پیام را با ضربدر ببندید وگرنه اینتر را بزنید 😁");

                x = 1;
            }
            else if(x==1)
            {
                this.Close();
            }
        }
        private void step3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (pic_circle.Location.X < 550 && pic_circle.Location.X > 450 && pic_circle.Location.Y < 350 && pic_circle.Location.Y > 250 && pic_fish.Location.X < 550 && pic_fish.Location.X > 450 && pic_fish.Location.Y < 350 && pic_fish.Location.Y > 250)
                    enter();

            }
            if (select == 1)
            {
                if (e.KeyCode.ToString() == "Down")
                    pic_circle.Location = new Point(pic_circle.Location.X, pic_circle.Location.Y + 10);
                if (e.KeyCode.ToString() == "Up")
                    pic_circle.Location = new Point(pic_circle.Location.X, pic_circle.Location.Y - 10);
                if (e.KeyCode.ToString() == "Right")
                    pic_circle.Location = new Point(pic_circle.Location.X + 10, pic_circle.Location.Y);
                if (e.KeyCode.ToString() == "Left")
                    pic_circle.Location = new Point(pic_circle.Location.X - 10, pic_circle.Location.Y);
                
            }
            if (select == 2)
            {
                if (e.KeyCode.ToString() == "Down")
                    pic_fish.Location = new Point(pic_fish.Location.X, pic_fish.Location.Y + 10);
                if (e.KeyCode.ToString() == "Up")
                    pic_fish.Location = new Point(pic_fish.Location.X, pic_fish.Location.Y - 10);
                if (e.KeyCode.ToString() == "Right")
                    pic_fish.Location = new Point(pic_fish.Location.X + 10, pic_fish.Location.Y);
                if (e.KeyCode.ToString() == "Left")
                    pic_fish.Location = new Point(pic_fish.Location.X - 10, pic_fish.Location.Y);
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
