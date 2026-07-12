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
    public partial class step11 : Form
    {
        public step11()
        {
            InitializeComponent();
        }

        private void step11_Load(object sender, EventArgs e)
        {
            pic_lab1.Visible = false;
            pic_led2.Visible = false;
            lab_info.Visible = false;
        }
        int x = 0;
        private void pic_led1_Click(object sender, EventArgs e)
        {
            pic_lab1.Visible = true;
            pic_lab2.Visible = false;
            pic_led1.Visible = false;
            pic_led2.Visible = true;
            lab_info.Visible = true;
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            int score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 11)
                File.WriteAllText("score", "11");
            MessageBox.Show("اگر میخواهید درباره مرحله پشت سر گذاشته اطلاعات داشته باشید پیام را با ضربدر ببندید وگرنه اینتر را بزنید 😁");

            x = 1;
        }

        private void step11_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return" && x == 1)
            {
                this.Close();
            }
        }
    }
}
