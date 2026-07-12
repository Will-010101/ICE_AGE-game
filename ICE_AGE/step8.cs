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
    public partial class step8 : Form
    {
        public step8()
        {
            InitializeComponent();
        }
        int x = 0;
        int y = 1;

        private void step8_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return" && x == 1)
            {
                this.Close();
            }
            else if (pic_sun.Location.X > 630)
            {
                pic_sun.Visible = false;
                y = 2;
                this.BackgroundImage = Properties.Resources.step8_2;
                pic_moon.Visible = true;
                pic_shah.Visible = true;
            }
            
            if (e.KeyCode.ToString() == "Right" && y == 1)
                pic_sun.Location = new Point(pic_sun.Location.X + 10, pic_sun.Location.Y);
            else if (e.KeyCode.ToString() == "Left" && y == 1)
                pic_sun.Location = new Point(pic_sun.Location.X - 10, pic_sun.Location.Y);
          

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

        private void step8_Load(object sender, EventArgs e)
        {
            pic_ex2.Visible = false;
            pic_moon.Visible = false;
            pic_shah.Visible = false;
            lab_info.Visible = false;
        }

        private void pic_shah_Click(object sender, EventArgs e)
        {
            pic_da.Visible = false;
            pic_shah.Visible = false;
            lab_info.Visible = true;
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            int score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 8)
                File.WriteAllText("score", "8");
            MessageBox.Show("اگر میخواهید درباره مرحله پشت سر گذاشته اطلاعات داشته باشید پیام را با ضربدر ببندید وگرنه اینتر را بزنید 😁");

            x = 1;
        }
    }
}
