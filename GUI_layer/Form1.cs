using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_layer
{
    public partial class GUI_studytimer : Form
    {
        private TimeSpan currentTime = TimeSpan.Zero;
        bool running = false;
        String mode = "study";
        public GUI_studytimer()
        {
            InitializeComponent();
            currentTime = new TimeSpan(studytime.Value.Hour, studytime.Value.Minute, studytime.Value.Second);
            timedisplay.Text = currentTime.ToString(@"hh\:mm\:ss");
        }
        private void startstop_Click(object sender, EventArgs e)
        {
            if (running)
            {
                clock.Stop();
                startstop.Text = "start";
                this.BackColor = Color.Green;
            }
            else
            {
                clock.Start();
                startstop.Text = "stop";
                this.BackColor = Color.Red;
            }
            running = !running;
        }
        private void clock_Tick(object sender, System.EventArgs e)
        {
            currentTime = currentTime.Subtract(TimeSpan.FromSeconds(clock.Interval / 1000));
            timedisplay.Text = currentTime.ToString(@"hh\:mm\:ss");
            if (currentTime == TimeSpan.Zero)
            {
                if (mode == "study")
                {
                    mode = "pause";
                    currentTime = new TimeSpan(pausetime.Value.Hour, pausetime.Value.Minute, pausetime.Value.Second);
                    this.BackColor = Color.Blue;
                }
                else
                {
                    mode = "study";
                    currentTime = new TimeSpan(studytime.Value.Hour, studytime.Value.Minute, studytime.Value.Second);
                    this.BackColor = Color.Red;
                }
                timedisplay.Text = currentTime.ToString(@"hh\:mm\:ss");
            }
        }
        private void settings_Click(object sender, EventArgs e)
        {
            settingsmenu.Visible = !settingsmenu.Visible;
        }
        private void confirmsettings_Click(object sender, EventArgs e)
        {
            if (mode == "pause")
            {
                currentTime = new TimeSpan(pausetime.Value.Hour, pausetime.Value.Minute, pausetime.Value.Second);
            }
            else
            {
                currentTime = new TimeSpan(studytime.Value.Hour, studytime.Value.Minute, studytime.Value.Second);
            }
            timedisplay.Text = currentTime.ToString(@"hh\:mm\:ss");
        }


    }
}
