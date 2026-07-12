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
    public partial class step5 : Form
    {
        public step5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pic_bal.Visible = true;
        }

        private void step5_Load(object sender, EventArgs e)
        {
            pic_bal.Visible = false;
            pic.Visible = false;
            lab_info.Visible = false;
            pic_ex2.Visible = false;
        }
        int x = 0;
        private void step5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return" && x == 1)
            {
                this.Close();
            }
            else if (pic_bal.Location.Y > 240)
            {
                pic_bal.Visible = false;
                pic_snake.Visible = false;
                pic.Visible = true;
                lab_info.Visible = true;
                StreamReader sr = File.OpenText("score");
                string score = sr.ReadLine();
                int score2 = Convert.ToInt16(score);
                sr.Close();
                if (score2 < 5)
                    File.WriteAllText("score", "5");
                MessageBox.Show("اگر میخواهید درباره مرحله پشت سر گذاشته اطلاعات داشته باشید پیام را با ضربدر ببندید وگرنه اینتر را بزنید 😁");

                x = 1;
            }
            if (e.KeyCode.ToString() == "Down")
                pic_bal.Location = new Point(pic_bal.Location.X, pic_bal.Location.Y + 10);
            if (e.KeyCode.ToString() == "Up")
                pic_bal.Location = new Point(pic_bal.Location.X, pic_bal.Location.Y - 10);
            
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
