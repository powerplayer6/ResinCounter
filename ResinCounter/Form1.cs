using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResinCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int resin = 0;
        int seks = 480;

        private void button1_Click(object sender, EventArgs e)
        {
            resin = int.Parse(textBox1.Text);
            timer1.Enabled = true;
            timer2.Enabled = true;
            textBox1.Enabled = false;
            label3.Text = seks.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            resin += 1;
            textBox1.Text = resin.ToString();
            seks = 480;
            label3.Text = seks.ToString();
            if(resin==20||resin==40)
            {
                notifyIcon1.ShowBalloonTip(1000, "Resin!", "Your resin is at "+resin+"!", ToolTipIcon.Info);
            }
            else if (resin == 60 || resin == 120)
            {
                notifyIcon1.ShowBalloonTip(1000, "Resin!", "Your resin is at " + resin + "!", ToolTipIcon.Info);
            }
            else if (resin == 160)
            {
                notifyIcon1.ShowBalloonTip(1000, "Resin!", "Your resin is at " + resin + "! It's capped!", ToolTipIcon.Info);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (seks > 1)
            { 
                seks -= 1;
                label3.Text = seks.ToString();
            }
            /*if (seks==470)
            {
                notifyIcon1.ShowBalloonTip(1000, "teST", "THIS IS SOME TEXT", ToolTipIcon.Info);
            }*/
        }
    }
}
