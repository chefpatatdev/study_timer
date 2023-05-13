using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            settingsApp = new Settings();
            statisticsApp = new Statistics();
            if (settingsApp.PathImage != "")
            {
                this.BackgroundImage = Image.FromFile(settingsApp.PathImage);
            }
            AUTO_START_BREAK_CHECK.Checked = settingsApp.AutoStartBreak;
            AUTO_START_STUDY_CHECKBOX.Checked = settingsApp.AutoStartStudy;
            studytime.Value = new DateTime(1753, 1, 1, TimeSpan.FromMinutes(settingsApp.StudeerTijd).Hours,TimeSpan.FromMinutes(settingsApp.StudeerTijd).Minutes, TimeSpan.FromMinutes(settingsApp.StudeerTijd).Seconds);
            pausetime.Value = new DateTime(1753, 1, 1, TimeSpan.FromMinutes(settingsApp.PauzeTijd).Hours, TimeSpan.FromMinutes(settingsApp.PauzeTijd).Minutes, TimeSpan.FromMinutes(settingsApp.PauzeTijd).Seconds);
            currentTime = new TimeSpan(studytime.Value.Hour, studytime.Value.Minute, studytime.Value.Second);
            timedisplay.Text = currentTime.ToString(@"hh\:mm\:ss");
            settingsApp = new Settings();
            statisticsApp = new Statistics();
            if(settingsApp.PathImage != "")
            {
                this.BackgroundImage = Image.FromFile(settingsApp.PathImage);
            }
            label1.Text = "#" + statisticsApp.Blocks;
            label2.Text = "Time to study!";

            if(settingsApp.PathSound == "")
            {
                settingsApp.PathSound = @"c:\Windows\Media\notify.wav";
            }
            this.SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer,
            true);
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
                    statisticsApp.Blocks += 1;
                    label1.Text = "#" + statisticsApp.Blocks;
                    
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
                playSound();
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
                label2.Text = "Time to study!";
            }
            else if (mode == "pause")
            {
                label2.Text = "Time for a break!";
            }
            if (!running)
            {
                clock.Stop();
                startstop.Text = "Start";
            }
            else
            {
                clock.Start();
                startstop.Text = "Stop";
            }
        }

        private void playSound()
        {
            using (var soundPlayer = new SoundPlayer(settingsApp.PathSound))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }

        private void studytime_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan span = studytime.Value - new DateTime(1753, 1, 1);
            settingsApp.StudeerTijd = (int)span.TotalMinutes;
        }

        private void pausetime_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan span = pausetime.Value - new DateTime(1753, 1, 1);
            settingsApp.PauzeTijd = (int)span.TotalMinutes;
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            { Console.WriteLine(openFileDialog1.FileName);
                settingsApp.PathImage = openFileDialog1.FileName;
                this.BackgroundImage = Image.FromFile(settingsApp.PathImage);

            }
            else
            { Console.WriteLine( "You didn't select the file!"); }
        }

        private void SELECT_SOUND_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Title = "Select File";
            openFileDialog2.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog2.Filter = "WAV (*.wav)|*.wav";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName != "")
            {
                Console.WriteLine(openFileDialog2.FileName);
                settingsApp.PathSound = openFileDialog2.FileName;
            }
            else
            { Console.WriteLine("You didn't select the file!"); }
        }

        private void timedisplay_Click(object sender, EventArgs e)
        {

        }

        private void CLEAR_BACKGROUND_Click(object sender, EventArgs e)
        {
            settingsApp.PathImage = "";
            this.BackgroundImage = null;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GUI_studytimer_Load(object sender, EventArgs e)
        {

        }
    }
}
