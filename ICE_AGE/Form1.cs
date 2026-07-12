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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score2 = 0;
        private void first_load()
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 >= 1)
            { pic_u_score1.Visible = true; pic_l_score1.Visible = false; }
            else
            { pic_l_score1.Visible = true; pic_u_score1.Visible = false; }
            if (score2 >= 2)
            { pic_u_score2.Visible = true; pic_l_score2.Visible = false; }
            else
            { pic_l_score2.Visible = true; pic_u_score2.Visible = false; }
            if (score2 >= 3)
            { pic_u_score3.Visible = true; pic_l_score3.Visible = false; }
            else
            { pic_l_score3.Visible = true; pic_u_score3.Visible = false; }
            if (score2 >= 4)
            { pic_u_score4.Visible = true; pic_l_score4.Visible = false; }
            else
            { pic_l_score4.Visible = true; pic_u_score4.Visible = false; }
            if (score2 >= 5)
            { pic_u_score5.Visible = true; pic_l_score5.Visible = false; }
            else
            { pic_l_score5.Visible = true; pic_u_score5.Visible = false; }
            if (score2 >= 6)
            { pic_u_score6.Visible = true; pic_l_score6.Visible = false; }
            else
            { pic_l_score6.Visible = true; pic_u_score6.Visible = false; }
            if (score2 >= 7)
            { pic_u_score7.Visible = true; pic_l_score7.Visible = false; }
            else
            { pic_l_score7.Visible = true; pic_u_score7.Visible = false; }
            if (score2 >= 8)
            { pic_u_score8.Visible = true; pic_l_score8.Visible = false; }
            else
            { pic_l_score8.Visible = true; pic_u_score8.Visible = false; }
            if (score2 >= 9)
            { pic_u_score9.Visible = true; pic_l_score9.Visible = false; }
            else
            { pic_l_score9.Visible = true; pic_u_score9.Visible = false; }
            if (score2 >= 10)
            { pic_u_score10.Visible = true; pic_l_score10.Visible = false; }
            else
            { pic_l_score10.Visible = true; pic_u_score10.Visible = false; }
            if (score2 >= 11)
            { pic_u_score11.Visible = true; pic_l_score11.Visible = false; }
            else
            { pic_l_score11.Visible = true; pic_u_score11.Visible = false; }
            if (score2 >= 12)
            { pic_u_score12.Visible = true; pic_l_score12.Visible = false; }
            else
            { pic_l_score12.Visible = true; pic_u_score12.Visible = false; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loding lod = new loding();
            lod.ShowDialog();
            pic2_setting.Visible = false;
            pic2_questions.Visible = false;
            pic2_information.Visible = false;
            pic2_exit.Visible = false;
            Stream stream = Properties.Resources.main_music;
            SoundPlayer player = new SoundPlayer(stream);
            player.Play();
            first_load();
        }
        private void pic1_setting_MouseEnter(object sender, EventArgs e)
        {
            pic2_setting.Visible = true;
        }

        private void pic1_setting_MouseLeave(object sender, EventArgs e)
        {
            pic2_setting.Visible = false;
        }

        private void pic1_questions_MouseEnter(object sender, EventArgs e)
        {
            pic2_questions.Visible = true;
        }

        private void pic1_questions_MouseLeave(object sender, EventArgs e)
        {
            pic2_questions.Visible = false;
        }

        private void pic1_information_MouseEnter(object sender, EventArgs e)
        {
            pic2_information.Visible = true;
        }

        private void pic1_information_MouseLeave(object sender, EventArgs e)
        {
            pic2_information.Visible = false;
        }

        private void pic1_exit_MouseEnter(object sender, EventArgs e)
        {
            pic2_exit.Visible = true;
        }

        private void pic1_exit_MouseLeave(object sender, EventArgs e)
        {
            pic2_exit.Visible = false;
        }

        private void pic1_exit_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void pic_back_1_MouseLeave(object sender, EventArgs e)
        {
            pic_back_1.BackColor = Color.Indigo;
            pic_l_score1.BackColor = Color.Indigo;
            pic_u_score1.BackColor = Color.Indigo;
            pic_score1.BackColor = Color.Indigo;
        }
        private void pic_u_score1_MouseEnter(object sender, EventArgs e)
        {
            if (score2 >= 1)
            { pic_back_1.BackColor = Color.MediumPurple; pic_l_score1.BackColor = Color.MediumPurple; pic_u_score1.BackColor = Color.MediumPurple; pic_score1.BackColor = Color.MediumPurple; }
            else
            { pic_back_1.BackColor = Color.DarkBlue; pic_l_score1.BackColor = Color.DarkBlue; pic_u_score1.BackColor = Color.DarkBlue; pic_score1.BackColor = Color.DarkBlue; }
        }

        private void pic_u_score2_MouseEnter(object sender, EventArgs e)
        {
            if (score2 >= 2)
            { pic_back_2.BackColor = Color.MediumPurple; pic_l_score2.BackColor = Color.MediumPurple; pic_u_score2.BackColor = Color.MediumPurple; pic_score2.BackColor = Color.MediumPurple; }
            else
            { pic_back_2.BackColor = Color.DarkBlue; pic_l_score2.BackColor = Color.DarkBlue; pic_u_score2.BackColor = Color.DarkBlue; pic_score2.BackColor = Color.DarkBlue; }
        }

        private void pic_u_score2_MouseLeave(object sender, EventArgs e)
        {
            pic_back_2.BackColor = Color.Indigo;
            pic_l_score2.BackColor = Color.Indigo;
            pic_u_score2.BackColor = Color.Indigo;
            pic_score2.BackColor = Color.Indigo;
        }

        private void pic_score3_MouseEnter(object sender, EventArgs e)
        {
            if (score2 >= 3)
            { pic_back_3.BackColor = Color.MediumPurple; pic_l_score3.BackColor = Color.MediumPurple; pic_u_score3.BackColor = Color.MediumPurple; pic_score3.BackColor = Color.MediumPurple; }
            else
            { pic_back_3.BackColor = Color.DarkBlue; pic_l_score3.BackColor = Color.DarkBlue; pic_u_score3.BackColor = Color.DarkBlue; pic_score3.BackColor = Color.DarkBlue; }
        }


        private void pic_score3_MouseLeave(object sender, EventArgs e)
        {
            pic_back_3.BackColor = Color.Indigo;
            pic_l_score3.BackColor = Color.Indigo;
            pic_u_score3.BackColor = Color.Indigo;
            pic_score3.BackColor = Color.Indigo;
        }

        private void pic_score4_MouseEnter(object sender, EventArgs e)
        {
            if (score2 >= 4)
            { pic_back_4.BackColor = Color.MediumPurple; pic_l_score4.BackColor = Color.MediumPurple; pic_u_score4.BackColor = Color.MediumPurple; pic_score4.BackColor = Color.MediumPurple; }
            else
            { pic_back_4.BackColor = Color.DarkBlue; pic_l_score4.BackColor = Color.DarkBlue; pic_u_score4.BackColor = Color.DarkBlue; pic_score4.BackColor = Color.DarkBlue; }
        }


        private void pic_score4_MouseLeave(object sender, EventArgs e)
        {
            pic_back_4.BackColor = Color.Indigo;
            pic_l_score4.BackColor = Color.Indigo;
            pic_u_score4.BackColor = Color.Indigo;
            pic_score4.BackColor = Color.Indigo;
        }

        private void pic_score5_MouseEnter(object sender, EventArgs e)
        {
            if (score2 >= 5)
            { pic_back_5.BackColor = Color.MediumPurple; pic_l_score5.BackColor = Color.MediumPurple; pic_u_score5.BackColor = Color.MediumPurple; pic_score5.BackColor = Color.MediumPurple; }
            else
            { pic_back_5.BackColor = Color.DarkBlue; pic_l_score5.BackColor = Color.DarkBlue; pic_u_score5.BackColor = Color.DarkBlue; pic_score5.BackColor = Color.DarkBlue; }
        }


        private void pic_score5_MouseLeave(object sender, EventArgs e)
        {
            pic_back_5.BackColor = Color.Indigo;
            pic_l_score5.BackColor = Color.Indigo;
            pic_u_score5.BackColor = Color.Indigo;
            pic_score5.BackColor = Color.Indigo;
        }

        private void pic_score6_MouseEnter(object sender, EventArgs e)
        {
            if (score2 >= 6)
            { pic_back_6.BackColor = Color.MediumPurple; pic_l_score6.BackColor = Color.MediumPurple; pic_u_score6.BackColor = Color.MediumPurple; pic_score6.BackColor = Color.MediumPurple; }
            else
            { pic_back_6.BackColor = Color.DarkBlue; pic_l_score6.BackColor = Color.DarkBlue; pic_u_score6.BackColor = Color.DarkBlue; pic_score6.BackColor = Color.DarkBlue; }
        }


        private void pic_score6_MouseLeave(object sender, EventArgs e)
        {
            pic_back_6.BackColor = Color.Indigo;
            pic_l_score6.BackColor = Color.Indigo;
            pic_u_score6.BackColor = Color.Indigo;
            pic_score6.BackColor = Color.Indigo;
        }

        private void pic_score7_MouseEnter(object sender, EventArgs e)
        {
            if (score2 >= 7)
            { pic_back_7.BackColor = Color.MediumPurple; pic_l_score7.BackColor = Color.MediumPurple; pic_u_score7.BackColor = Color.MediumPurple; pic_score7.BackColor = Color.MediumPurple; }
            else
            { pic_back_7.BackColor = Color.DarkBlue; pic_l_score7.BackColor = Color.DarkBlue; pic_u_score7.BackColor = Color.DarkBlue; pic_score7.BackColor = Color.DarkBlue; }
        }


        private void pic_score7_MouseLeave(object sender, EventArgs e)
        {
            pic_back_7.BackColor = Color.Indigo;
            pic_l_score7.BackColor = Color.Indigo;
            pic_u_score7.BackColor = Color.Indigo;
            pic_score7.BackColor = Color.Indigo;
        }

        private void pic_score8_MouseEnter(object sender, EventArgs e)
        {
            if (score2 >= 8)
            { pic_back_8.BackColor = Color.MediumPurple; pic_l_score8.BackColor = Color.MediumPurple; pic_u_score8.BackColor = Color.MediumPurple; pic_score8.BackColor = Color.MediumPurple; }
            else
            { pic_back_8.BackColor = Color.DarkBlue; pic_l_score8.BackColor = Color.DarkBlue; pic_u_score8.BackColor = Color.DarkBlue; pic_score8.BackColor = Color.DarkBlue; }
        }


        private void pic_score8_MouseLeave(object sender, EventArgs e)
        {
            pic_back_8.BackColor = Color.Indigo;
            pic_l_score8.BackColor = Color.Indigo;
            pic_u_score8.BackColor = Color.Indigo;
            pic_score8.BackColor = Color.Indigo;
        }

        private void pic_score9_MouseEnter(object sender, EventArgs e)
        {
            if (score2 >= 9)
            { pic_back_9.BackColor = Color.MediumPurple; pic_l_score9.BackColor = Color.MediumPurple; pic_u_score9.BackColor = Color.MediumPurple; pic_score9.BackColor = Color.MediumPurple; }
            else
            { pic_back_9.BackColor = Color.DarkBlue; pic_l_score9.BackColor = Color.DarkBlue; pic_u_score9.BackColor = Color.DarkBlue; pic_score9.BackColor = Color.DarkBlue; }
        }

        private void pic_score9_MouseLeave(object sender, EventArgs e)
        {
            pic_back_9.BackColor = Color.Indigo;
            pic_l_score9.BackColor = Color.Indigo;
            pic_u_score9.BackColor = Color.Indigo;
            pic_score9.BackColor = Color.Indigo;
        }

        private void pic_score10_MouseEnter(object sender, EventArgs e)
        {
            if (score2 >= 10)
            { pic_back_10.BackColor = Color.MediumPurple; pic_l_score10.BackColor = Color.MediumPurple; pic_u_score10.BackColor = Color.MediumPurple; pic_score10.BackColor = Color.MediumPurple; }
            else
            { pic_back_10.BackColor = Color.DarkBlue; pic_l_score10.BackColor = Color.DarkBlue; pic_u_score10.BackColor = Color.DarkBlue; pic_score10.BackColor = Color.DarkBlue; }
        }


        private void pic_score10_MouseLeave(object sender, EventArgs e)
        {
            pic_back_10.BackColor = Color.Indigo;
            pic_l_score10.BackColor = Color.Indigo;
            pic_u_score10.BackColor = Color.Indigo;
            pic_score10.BackColor = Color.Indigo;
        }

        private void pic_score11_MouseEnter(object sender, EventArgs e)
        {
            if (score2 >= 11)
            { pic_back_11.BackColor = Color.MediumPurple; pic_l_score11.BackColor = Color.MediumPurple; pic_u_score11.BackColor = Color.MediumPurple; pic_score11.BackColor = Color.MediumPurple; }
            else
            { pic_back_11.BackColor = Color.DarkBlue; pic_l_score11.BackColor = Color.DarkBlue; pic_u_score11.BackColor = Color.DarkBlue; pic_score11.BackColor = Color.DarkBlue; }
        }


        private void pic_score11_MouseLeave(object sender, EventArgs e)
        {
            pic_back_11.BackColor = Color.Indigo;
            pic_l_score11.BackColor = Color.Indigo;
            pic_u_score11.BackColor = Color.Indigo;
            pic_score11.BackColor = Color.Indigo;
        }

        private void pic_score12_MouseEnter(object sender, EventArgs e)
        {
            if (score2 >= 12)
            { pic_back_12.BackColor = Color.MediumPurple; pic_l_score12.BackColor = Color.MediumPurple; pic_u_score12.BackColor = Color.MediumPurple; pic_score12.BackColor = Color.MediumPurple; }
            else
            { pic_back_12.BackColor = Color.DarkBlue; pic_l_score12.BackColor = Color.DarkBlue; pic_u_score12.BackColor = Color.DarkBlue; pic_score12.BackColor = Color.DarkBlue; }
        }


        private void pic_score12_MouseLeave(object sender, EventArgs e)
        {
            pic_back_12.BackColor = Color.Indigo;
            pic_l_score12.BackColor = Color.Indigo;
            pic_u_score12.BackColor = Color.Indigo;
            pic_score12.BackColor = Color.Indigo;
        }

        private void pic1_setting_MouseDown(object sender, MouseEventArgs e)
        {
            setting set = new setting();
            set.ShowDialog();
        }

        private void pic_u_score1_MouseDown(object sender, MouseEventArgs e)
        {
            step1 st1 = new step1();
            st1.ShowDialog();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                first_load();
            }
        }

        private void pic2_questions_MouseDown(object sender, MouseEventArgs e)
        {
            information info = new information();
            info.ShowDialog();
        }

        private void pic2_questions_MouseDown_1(object sender, MouseEventArgs e)
        {
            questions ques = new questions();
            ques.ShowDialog();
        }

        private void pic_score2_MouseDown(object sender, MouseEventArgs e)
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 1)
                MessageBox.Show("امتیاز شما برای ورود به این مرحله کافی نیست");
            else
            {
                step2 st2 = new step2();
                st2.ShowDialog();
            }
        }

        private void pic_score3_MouseDown(object sender, MouseEventArgs e)
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 2)
                MessageBox.Show("امتیاز شما برای ورود به این مرحله کافی نیست");
            else
            {
                step3 st3 = new step3();
                st3.ShowDialog();
            }
        }

        private void pic_score4_MouseDown(object sender, MouseEventArgs e)
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 3)
                MessageBox.Show("امتیاز شما برای ورود به این مرحله کافی نیست");
            else
            {
                stpe4 st4 = new stpe4();
                st4.ShowDialog();
            }
        }

        private void pic_score5_MouseDown(object sender, MouseEventArgs e)
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 4)
                MessageBox.Show("امتیاز شما برای ورود به این مرحله کافی نیست");
            else
            {
                step5 st5 = new step5();
                st5.ShowDialog();
            }
        }

        private void pic_score6_MouseDown(object sender, MouseEventArgs e)
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 5)
                MessageBox.Show("امتیاز شما برای ورود به این مرحله کافی نیست");
            else
            {
                step6 st6 = new step6();
                st6.ShowDialog();
            }
        }

        private void pic_score7_MouseDown(object sender, MouseEventArgs e)
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 6)
                MessageBox.Show("امتیاز شما برای ورود به این مرحله کافی نیست");
            else
            {
                step7 st7 = new step7();
                st7.ShowDialog();
            }
        }

        private void pic_score8_MouseDown(object sender, MouseEventArgs e)
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 7)
                MessageBox.Show("امتیاز شما برای ورود به این مرحله کافی نیست");
            else
            {
                step8 st8 = new step8();
                st8.ShowDialog();
            }
        }

        private void pic_u_score9_MouseDown(object sender, MouseEventArgs e)
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 8)
                MessageBox.Show("امتیاز شما برای ورود به این مرحله کافی نیست");
            else
            {
                step9 st9 = new step9();
                st9.ShowDialog();
            }
        }

        private void pic_score10_MouseDown(object sender, MouseEventArgs e)
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 9)
                MessageBox.Show("امتیاز شما برای ورود به این مرحله کافی نیست");
            else
            {
                step10 st10 = new step10();
                st10.ShowDialog();
            }
        }

        private void pic_score11_MouseDown(object sender, MouseEventArgs e)
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 10)
                MessageBox.Show("امتیاز شما برای ورود به این مرحله کافی نیست");
            else
            {
                step11 st11 = new step11();
                st11.ShowDialog();
            }
        }

        private void pic_score12_MouseDown(object sender, MouseEventArgs e)
        {
            StreamReader sr = File.OpenText("score");
            string score = sr.ReadLine();
            score2 = Convert.ToInt16(score);
            sr.Close();
            if (score2 < 11)
                MessageBox.Show("امتیاز شما برای ورود به این مرحله کافی نیست");
            else
            {
                step12 st12 = new step12();
                st12.ShowDialog();
            }
        }
    }
}
