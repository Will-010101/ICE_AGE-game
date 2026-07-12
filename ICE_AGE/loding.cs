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
    public partial class loding : Form
    {
        public loding()
        {
            InitializeComponent();
        }

        private void loding_Load(object sender, EventArgs e)
        {
            timer_loding.Start();
        }
        int count_loding = 0;
        private void timer_loding_Tick(object sender, EventArgs e)
        {
            count_loding++;
            if (count_loding >= 1 && count_loding <= 55)
            {
                var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "play1.mp4");

                try
                {
                    File.WriteAllBytes(strTempFile, Properties.Resources.play1);
                    player1.URL = strTempFile;
                    player1.Ctlcontrols.play();
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                player1.Ctlcontrols.stop();
                timer_loding.Stop(); this.Close();
            }
        }

        private void player1_Enter(object sender, EventArgs e)
        {

        }
    }
}
