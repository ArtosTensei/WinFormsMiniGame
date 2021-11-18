using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Game
{
    public partial class UserControl1 : UserControl
    {
        private DateTime StartTime;
        int time = 0;
        Random rand = new Random();
        public UserControl1()
        {
            InitializeComponent();
            timer3.Enabled = !timer3.Enabled;
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            this.BackColor = DefaultBackColor;
            timer3.Enabled = !timer3.Enabled;
            start.Enabled = false;
        }

        private void playGame_Click(object sender, EventArgs e)
        {
            label1.Text = "00:00:00:000:0";
            time = rand.Next(2, 6);
            timer2.Enabled = !timer2.Enabled;
            StartTime = DateTime.Now;
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;
            string text = "";
            int tenths = elapsed.Milliseconds / 100;
            text +=
                elapsed.Hours.ToString("00") + ":" +
                elapsed.Minutes.ToString("00") + ":" +
                elapsed.Seconds.ToString("00") + ":" +
                elapsed.Milliseconds.ToString("000") + ":" +
                tenths.ToString("0");

            label1.Text = text;
        }

        private void tmrClock1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;
            if (time == elapsed.Seconds)
            {
                this.BackColor = System.Drawing.Color.Green;
                timer2.Enabled = !timer2.Enabled;
            }
        }

        private void tmrClock2_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == System.Drawing.Color.Green)
            {
                timer1.Enabled = !timer1.Enabled;
                StartTime = DateTime.Now;
                timer3.Enabled = !timer3.Enabled;
                start.Enabled = true;
            }

        }
    }
}
