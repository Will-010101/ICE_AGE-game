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
    public partial class step6 : Form
    {
        public step6()
        {
            InitializeComponent();
        }

        private void step6_Load(object sender, EventArgs e)
        {
            pic_da.Visible = false;
            lab_info.Visible = false;
            pic_ex2.Visible = false;
        }
        int x = 0;
        private void step6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return" && x == 1)
            {
                this.Close();
            }
            else if (pic.Location.X <190)
            {
                pic.Visible = false;
                pic_lac.Visible = false;
                pic_da.Visible = true;
                lab_info.Visible = true;
                StreamReader sr = File.OpenText("score");
                string score = sr.ReadLine();
                int score2 = Convert.ToInt16(score);
                sr.Close();
                if (score2 < 6)
                    File.WriteAllText("score", "6");
                MessageBox.Show("اگر میخواهید درباره مرحله پشت سر گذاشته اطلاعات داشته باشید پیام را با ضربدر ببندید وگرنه اینتر را بزنید 😁");

                x = 1;
            }
            if (e.KeyCode.ToString() == "Right")
                pic.Location = new Point(pic.Location.X + 10, pic.Location.Y);
            if (e.KeyCode.ToString() == "Left")
                pic.Location = new Point(pic.Location.X - 10, pic.Location.Y);
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
