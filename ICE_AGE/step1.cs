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
    public partial class step1 : Form
    {
        public step1()
        {
            InitializeComponent();
        }

        private void step1_Load(object sender, EventArgs e)
        {
            panel_first.Visible = true;
            pic_1.Visible = false;
            pic_mun_1.Visible = false;
            pic_mun_2.Visible = false;
            panel1.Visible = false;
            pic_fish.Visible = false;
            pic_ex2.Visible = false;
            lab_info.Visible = false;
        }

        private void panel_first_MouseDown(object sender, MouseEventArgs e)
        {
            panel_first.Visible = false;
            this.BackgroundImage = Properties.Resources.step1_2;
            pic_1.Visible = true;
        }

        private void pic_1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.step1_3;
            pic_1.Visible = false;
            pic_mun_1.Visible = true;
            pic_mun_2.Visible = true;
            panel1.Visible = true;
        }
        int x = 0;
        private void step1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Down")
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 10);
            if (e.KeyCode.ToString() == "Up")
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 10);
            if (e.KeyCode.ToString() == "Right")
                panel1.Location = new Point(panel1.Location.X + 10, panel1.Location.Y);
            if (e.KeyCode.ToString() == "Left")
                panel1.Location = new Point(panel1.Location.X - 10, panel1.Location.Y);
            if (e.KeyCode.ToString() == "Return" && x==0)
            {
                if (panel1.Location.X > 68 && panel1.Location.X < 83 && panel1.Location.Y>312 && panel1.Location.Y < 328)
                {
                    pic_fish.Visible = true;
                    panel1.Visible = false;
                    lab_info.Visible = true;
                    StreamReader sr = File.OpenText("score");
                    string score = sr.ReadLine();
                    int score2 = Convert.ToInt16(score);
                    sr.Close();
                    if (score2 < 1)
                        File.WriteAllText("score", "1") ;
                    MessageBox.Show("اگر میخواهید درباره مرحله پشت سر گذاشته اطلاعات داشته باشید پیام را با ضربدر ببندید وگرنه اینتر را بزنید 😁");
                    
                    x = 1;
                }
            }
            else if(e.KeyCode.ToString() == "Return" && x==1)
            {
                this.Close();
            }
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

        private void lab_info_Click(object sender, EventArgs e)
        {

        }

        private void pic_ex_Click(object sender, EventArgs e)
        {

        }
    }
}
