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
    public partial class step12 : Form
    {
        public step12()
        {
            InitializeComponent();
        }
        int x = 0;
        private void pic1_Click(object sender, EventArgs e)
        {
            pic1.Visible = false;
            this.BackgroundImage = Properties.Resources.step12_2;
            pic2.Visible = true;
            

        }

        private void step12_Load(object sender, EventArgs e)
        {
            pic2.Visible = false;
            lab_info.Visible = false;
        }

        private void step12_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return" && x == 1)
            {
                this.Close();
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            lab_info.Visible = true;
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            int score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 12)
                File.WriteAllText("score", "12");
            MessageBox.Show("اگر میخواهید درباره مرحله پشت سر گذاشته اطلاعات داشته باشید پیام را با ضربدر ببندید وگرنه اینتر را بزنید 😁");

            x = 1;
        }
    }
}
