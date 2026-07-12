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
    public partial class step10 : Form
    {
        public step10()
        {
            InitializeComponent();
        }

        private void step10_Load(object sender, EventArgs e)
        {
            pic_home.Visible = false;
            lab_info.Visible = false;
        }
        int x = 0;
        private void pic_ch_Click(object sender, EventArgs e)
        {
            pic_ch.Visible = false;
            pic_home.Visible = true;
            lab_info.Visible = true;
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            int score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 10)
                File.WriteAllText("score", "10");
            MessageBox.Show("اگر میخواهید درباره مرحله پشت سر گذاشته اطلاعات داشته باشید پیام را با ضربدر ببندید وگرنه اینتر را بزنید 😁");

            x = 1;
        }

        private void step10_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return" && x == 1)
            {
                this.Close();
            }
        }
    }
}
