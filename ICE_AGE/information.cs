using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE_AGE
{
    public partial class information : Form
    {
        public information()
        {
            InitializeComponent();
        }
        int count = 0;
        private void counter_form()
        {
            if(count==0)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
            }
            if (count == 1)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
            }
            if (count == 2)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
            }
        }
        private void information_Load(object sender, EventArgs e)
        {
            pic2_home.Visible = false;
            counter_form();
        }
        private void pic1_home_MouseEnter(object sender, EventArgs e)
        {
            pic2_home.Visible = true;
        }

        private void pic1_home_MouseLeave(object sender, EventArgs e)
        {
            pic2_home.Visible = false;
        }

        private void pic2_home_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 3) count = 0;
            counter_form();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            count--;
            if (count == -1) count = 2;
            counter_form();
        }
    }
}
