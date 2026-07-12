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
    public partial class questions : Form
    {
        public questions()
        {
            InitializeComponent();
        }
        string[] qus = { "1","2","3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20","21","22","23" ,"24"};
        string[] ans = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23","24" };
        int num_ans = 0;
        private void questions_Load(object sender, EventArgs e)
        {
            pic2_tick.Visible = false;
            pic2_home.Visible = false;
            qus[0] = "دوران سیوزوییک چند میلیون سال طول کشید؟";
            qus[1] = "کوتاهترین دوران زمین شناسی کدام دوران است؟";
            qus[2] = "گسترش فوق العاده گیاهان نهان دانه و تک لپه در کدام دوران است؟";
            qus[3] = "برخاستن و فرسایش کدام کوه در دوران سیوزوییک صروت گرفت؟";
            qus[4] = "در نتیجه فعالیت زمین ساختی دوره سیوزوییک به جز البرز کدام رشته کوه در ایران شکل گرفت؟";
            qus[5] = "مهمترین حادثه دوران سیوزوییک گسترش و تنوع .... است.";
            qus[6] = "کدام دوره زمین شناسی را دوره پستانداران گویند؟";
            qus[7] = "میانه زیستی یا ... نام دوره ای از زمین شناسی است.";
            qus[8] = "کدام دوره زمین شناسی مابین دوره های دیرینه زیستی و نوزیستی قرار دارد؟";
            qus[9] = "دوره مزوزوییک چند میلیون سال طول کشید؟";
            qus[10] = "دوره مزوزوییک شامل سه دوره ... ژوراسیک و کرتاسه بود.";
            qus[11] = "علاوه بر شاخ چوقی کدام جانور در دوران مزوزوییک زیسته و منقرض شد؟";
            qus[12] = "اب و هوای دوره مزوزوییک گرم و .... بوده است. ";
            qus[13] = "در دوران مزوزوییک اب و هوا نسبت به الان ثبات بیشتری داشته یا کمتر؟";
            qus[14] = "لوازیا شامل قاره های اسیا اروپا امریکای شمالی و ... بوده است.";
            qus[15] = "در دوران پالیوزوییک با وفور جانوران بی.... روبرو هستیم. ";
            qus[16] = "در دوران .... قاره بزرگ پانگه‌آ از اقیانوس ها بیرون امدند. ";
            qus[17] = "جانوری از گروه بندپایان زا نام ببرید که دارای پوست است و در دوران پالیوزوییک زندگی میکرد.";
            qus[18] = "در زمان ظهور اولین مهره داران کدام دسته بودند؟ ";
            qus[19] = "به دلیل پوشیدگی بدن مهره داران از صفحات استخوانی به انها چه میگفتند؟";
            qus[20] = "ایا این جمله که اولین گیاهان ریشه و ساقه نداشتند درست است؟";
            qus[21] = "گیاهانی که ریشه و ساقه نداشتند با چه چیزی تولید مثل میکردند؟";
            qus[22] = "اولین خزنده که در دنیا دیده شد شبیه .... بود.";
            qus[23] = "با ظهور ..... تریلوبیت ها منقرض شدند.";
            ans[0] = "66"; ans[1] = "سیوزوییک";ans[2] = "سیوزوییک";ans[3] = "الپ";ans[4] = "زاگرس";ans[5] = "پستانداران";ans[6] = "سیوزوییک";
            ans[7] = "مزوزوییک";ans[8] = "مزوزوییک";ans[9] = "160";ans[10] = "تریاس";ans[11] = "دایناسور";ans[12] = "استوایی";ans[13] = "بیشتر";ans[14] = "گرینلند";
            ans[15] = "مهره";ans[16] = "پالیوزوییک";ans[17] = "تریلوبیت";ans[18] = "ماهی";ans[19] = "زرهدار";ans[20] = "بله";ans[21] = "هاگ";ans[22] = "سوسمار";ans[23] = "خزندگان";
            Random generator = new Random();
            int num = generator.Next(23);
            num_ans = num;
            label5.Text = qus[num];
            StreamReader sr = File.OpenText("question_score");
            string score = sr.ReadLine();
            sr.Close();
            label3.Text = score;
        }

        private void pic1_tick_MouseEnter(object sender, EventArgs e)
        {
            pic2_tick.Visible = true;
        }

        private void pic1_tick_MouseLeave(object sender, EventArgs e)
        {
            pic2_tick.Visible = false;
        }

        private void pic1_tick_MouseDown(object sender, MouseEventArgs e)
        {
            if(textBox1.Text==ans[num_ans])
            {
                StreamReader sr = File.OpenText("question_score");
                string score1 = sr.ReadLine();
                sr.Close();
                int s= Convert.ToInt16(score1);
                s++;
                score1 = s.ToString();
                File.WriteAllText("question_score", score1);
                label3.Text = score1;
                textBox1.Text = "";
                Random generator = new Random();
                int num = generator.Next(23);
                num_ans = num;
                label5.Text = qus[num];
                MessageBox.Show("پاسخ شما درست بود😀");
            }
            else
            {
                StreamReader sr = File.OpenText("question_false");
                string score1 = sr.ReadLine();
                sr.Close();
                int s = Convert.ToInt16(score1);
                s++;
                score1 = s.ToString();
                File.WriteAllText("question_false", score1);
                textBox1.Text = "";
                MessageBox.Show("پاسخ شما درست نبود😪");
            }
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
    }
}
