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
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }
        private void reset_score()
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            sr.Close();
            label3.Text = score;
            StreamReader sm = File.OpenText("question_score");
            string ques = sm.ReadLine();
            sm.Close();
            label5.Text = ques;
            StreamReader ss = File.OpenText("question_false");
            string fal = ss.ReadLine();
            ss.Close();
            int q1 = Convert.ToInt16(ques);
            int f1 = Convert.ToInt16(fal);
            f1 = f1 + q1;
            if (f1 == 0)
                label8.Text = "0";
            else
            {
                int d = q1 * 100 / f1;
                label8.Text = d.ToString();
            }
        }
        private void setting_Load(object sender, EventArgs e)
        {
            dis_setting.BackColor = Color.DeepPink;
            dis_information.BackColor = Color.DarkSlateBlue;
            pic2_setting.Visible = false;
            pic2_information.Visible = false;
            pic2_home.Visible = false;
            panel_information.Visible = false;
            reset_score();
        }

        private void pic1_setting_MouseEnter(object sender, EventArgs e)
        {
            pic2_setting.Visible = true;
        }

        private void pic1_setting_MouseLeave(object sender, EventArgs e)
        {
            pic2_setting.Visible = false;
        }

        private void pic1_information_MouseEnter(object sender, EventArgs e)
        {
            pic2_information.Visible = true;
        }

        private void pic1_information_MouseLeave(object sender, EventArgs e)
        {
            pic2_information.Visible = false;
        }

        private void pic1_setting_MouseDown(object sender, MouseEventArgs e)
        {
            panel_information.Visible = false;
            panel_setting.Visible = true;
            dis_information.BackColor = Color.DarkSlateBlue;
            dis_setting.BackColor = Color.DeepPink;
            panel_setting.Visible = true;
            panel_information.Visible = false;
        }

        private void lab_infromation_MouseDown(object sender, MouseEventArgs e)
        {
            panel_information.Visible = true;
            panel_setting.Visible = false;
            dis_information.BackColor = Color.DeepPink;
            dis_setting.BackColor = Color.DarkSlateBlue;
            panel_information.Visible = true;
            panel_setting.Visible = false;
        }

        private void pic1_home_MouseEnter(object sender, EventArgs e)
        {
            pic2_home.Visible = true;
        }

        private void pic1_home_MouseLeave(object sender, EventArgs e)
        {
            pic2_home.Visible = false;
        }

        private void pic1_home_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream stream = Properties.Resources.main_music;
            SoundPlayer player = new SoundPlayer(stream);
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream stream = Properties.Resources.main_music;
            SoundPlayer player = new SoundPlayer(stream);
            player.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("question_false","0");
            File.WriteAllText("question_score","0");
            reset_score();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText("score","0");
            reset_score();
            MessageBox.Show("پس از برگشتن به خانه اینتر را بزنید😁");
        }
    }
}
