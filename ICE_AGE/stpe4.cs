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
    public partial class stpe4 : Form
    {
        public stpe4()
        {
            InitializeComponent();
        }

        private void stpe4_Load(object sender, EventArgs e)
        {
            track.Visible = false;
            pic_snake.Visible = false;
            pic_2home.Visible = false;
            lab_info.Visible = false;

        }
        int x = 0;
        private void stpe4_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (pic.Location.X > 250 && pic.Location.X < 290 && pic.Location.Y > 160 && pic.Location.Y < 200)
            {
                pic.Visible = false;
                track.Visible = true;
            }
            if (e.KeyCode.ToString() == "Down")
                pic.Location = new Point(pic.Location.X, pic.Location.Y + 10);
            if (e.KeyCode.ToString() == "Up")
                pic.Location = new Point(pic.Location.X, pic.Location.Y - 10);
            if (e.KeyCode.ToString() == "Right")
                pic.Location = new Point(pic.Location.X + 10, pic.Location.Y);
            if (e.KeyCode.ToString() == "Left")
                pic.Location = new Point(pic.Location.X - 10, pic.Location.Y);
            if (e.KeyCode.ToString() == "Return" && x == 1)
            {
                this.Close();
            }
        }
        private void track_Scroll(object sender, EventArgs e)
        {
            if(track.Value==100 && x==0)
            {
                pic_snake.Visible = true;
                track.Visible = false;
                lab_info.Visible = true;
                StreamReader sr = File.OpenText("score");
                string score = sr.ReadLine();
                int score2 = Convert.ToInt16(score);
                sr.Close();
                if (score2 < 4)
                    File.WriteAllText("score", "4");
                MessageBox.Show("اگر میخواهید درباره مرحله پشت سر گذاشته اطلاعات داشته باشید پیام را با ضربدر ببندید وگرنه اینتر را بزنید 😁");

                x = 1;
            }
        }


  

        private void pic_1home_MouseEnter_1(object sender, EventArgs e)
        {
            pic_2home.Visible = true;
        }

        private void pic_1home_MouseLeave_1(object sender, EventArgs e)
        {
            pic_2home.Visible = false;
        }

        private void pic_1home_MouseDown_1(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
