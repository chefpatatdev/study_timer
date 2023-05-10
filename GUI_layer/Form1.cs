﻿using System;
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

        public Settings settingsApp;
        public Statistics statisticsApp;
        

        public GUI_studytimer()
        {
            InitializeComponent();
            currentTime = new TimeSpan(studytime.Value.Hour, studytime.Value.Minute, studytime.Value.Second);
            timedisplay.Text = currentTime.ToString(@"hh\:mm\:ss");
            settingsApp = new Settings();
            statisticsApp = new Statistics();

        }
        private void startstop_Click(object sender, EventArgs e)
        {
            running = !running;
            updateScreen();
        }
        private void clock_Tick(object sender, System.EventArgs e)
        {
            currentTime = currentTime.Subtract(TimeSpan.FromSeconds(clock.Interval / 1000));
            timedisplay.Text = currentTime.ToString(@"hh\:mm\:ss");
            if (currentTime == TimeSpan.Zero)
            {
                if (mode == "study")
                {
                    running = settingsApp.AutoStartBreak;
                    mode = "pause";
                    updateScreen();
                    currentTime = new TimeSpan(pausetime.Value.Hour, pausetime.Value.Minute, pausetime.Value.Second);
                }
                else
                {
                    running = settingsApp.AutoStartStudy;
                    mode = "study";
                    updateScreen();
                    currentTime = new TimeSpan(studytime.Value.Hour, studytime.Value.Minute, studytime.Value.Second);
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

        private void settingsmenu_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            settingsApp.AutoStartBreak = AUTO_START_BREAK_CHECK.Checked;
            Console.WriteLine(settingsApp.AutoStartBreak);
        }

        private void AUTO_START_STUDY_CHECKBOX_CheckedChanged(object sender, EventArgs e)
        {
            settingsApp.AutoStartStudy = AUTO_START_STUDY_CHECKBOX.Checked;
        }

        private void updateScreen()
        {
            if (mode == "study")
            {
                this.BackColor = Color.Red;
            }
            else if (mode == "pause")
            {
                this.BackColor = Color.Blue;
            }
            if (!running)
            {
                clock.Stop();
                startstop.Text = "start";
            }
            else
            {
                clock.Start();
                startstop.Text = "stop";
            }
        }
    }
}
