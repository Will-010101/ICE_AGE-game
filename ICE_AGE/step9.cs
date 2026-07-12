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
    public partial class step9 : Form
    {
        public step9()
        {
            InitializeComponent();
        }
        int x = 0;
        private void step9_Load(object sender, EventArgs e)
        {
            pic_wallnoot.Visible = false;
            pic_human.Visible = false;
            lab_info.Visible = false;
            pic_ex2.Visible = false;
        }

        private void pic_tree_Click(object sender, EventArgs e)
        {
            pic_wallnoot.Visible = true;
            pic_tree.Visible = false;
        }

        private void pic_wallnoot_Click(object sender, EventArgs e)
        {
            pic_munky.Visible = false;
            pic_human.Visible = true;
            lab_info.Visible = true;
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            int score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 9)
                File.WriteAllText("score", "9");
            MessageBox.Show("اگر میخواهید درباره مرحله پشت سر گذاشته اطلاعات داشته باشید پیام را با ضربدر ببندید وگرنه اینتر را بزنید 😁");

            x = 1;
        }

        private void step9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return" && x == 1)
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
    }
}
