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

/*
 * Purpouse: EventHandlers and GUI functionality
 * @author Ricky Da Silva Marques & Thomas Ocket
 */

namespace GUI_layer
{
    public partial class GUI_studytimer : Form
    {
        private TimeSpan currentTime = TimeSpan.Zero;
        bool running = false;
        String mode = "study";

        public Settings settingsApp;
        public Statistics statisticsApp;

        public GUI_studytimer() //Ricky Da Silva Marques & Thomas Ocket
        {
            //Initialize all the components used in the GUI
            InitializeComponent();

            //Create the settings and statistics objects
            settingsApp = new Settings();
            statisticsApp = new Statistics();

            //Display the checkboxes accordingly to the saved status of them
            AUTO_START_BREAK_CHECK.Checked = settingsApp.AutoStartBreak;
            AUTO_START_STUDY_CHECKBOX.Checked = settingsApp.AutoStartStudy;

            //Display the time selectors to the saved values of them
            studytime.Value = new DateTime(1753, 1, 1, TimeSpan.FromMinutes(settingsApp.StudeerTijd).Hours,TimeSpan.FromMinutes(settingsApp.StudeerTijd).Minutes, TimeSpan.FromMinutes(settingsApp.StudeerTijd).Seconds);
            pausetime.Value = new DateTime(1753, 1, 1, TimeSpan.FromMinutes(settingsApp.PauzeTijd).Hours, TimeSpan.FromMinutes(settingsApp.PauzeTijd).Minutes, TimeSpan.FromMinutes(settingsApp.PauzeTijd).Seconds);
            
            //Display the timer value on screen
            currentTime = new TimeSpan(studytime.Value.Hour, studytime.Value.Minute, studytime.Value.Second);
            DisplayCurrentTime();

            //On startup of the application set the background to the one saved, when its not empty the path.
            if (settingsApp.PathImage != "")
            {
                this.BackgroundImage = Image.FromFile(settingsApp.PathImage);
            }

            //On startup of the application set the notificationsound to a default windows sound when path is empty.
            if (settingsApp.PathSound == "")
            {
                settingsApp.PathSound = @"c:\Windows\Media\notify.wav";
            }

            //Display the amount of blocks and mode
            LABEL_AMOUNT_BLOCKS.Text = "#" + statisticsApp.Blocks;
            LABEL_MODE.Text = "Time to study!";

            //To prevent background flickering when setting a custom background image
            this.SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer,
            true);
        }

        //Eventhandler for START_STOP_BUTTON, toggles the running state of the timer and updates the screen
        private void START_STOP_BUTTON_Click(object sender, EventArgs e) //Thomas Ocket
        {
            running = !running;
            UpdateScreen();
        }

        //Eventhandler for clock tick, checks if the timer has run out of time and updates the screen accordingly.
        private void clock_Tick(object sender, System.EventArgs e) //Thomas Ocket
        {
            currentTime = currentTime.Subtract(TimeSpan.FromSeconds(clock.Interval / 1000));
            if (currentTime == TimeSpan.Zero) //Check if the timer is 00:00:00
            {
                if (mode == "study") //When mode is study then change to pause and update
                {
                    statisticsApp.Blocks += 1;
                    LABEL_AMOUNT_BLOCKS.Text = "#" + statisticsApp.Blocks;
                    running = settingsApp.AutoStartBreak;
                    mode = "pause";

                    //Get the pausetime to display it
                    currentTime = new TimeSpan(pausetime.Value.Hour, pausetime.Value.Minute, pausetime.Value.Second);
                }
                else //When mode is pause change to study and update
                { 
                    running = settingsApp.AutoStartStudy;
                    mode = "study";

                    //Get the pausetime to display it
                    currentTime = new TimeSpan(studytime.Value.Hour, studytime.Value.Minute, studytime.Value.Second);
                }
                UpdateScreen();
                PlaySound();
            }
            DisplayCurrentTime();
        }

        //Eventhandler for settingsmenu button, toggles the visiblity
        private void settings_Click(object sender, EventArgs e) //Thomas Ocket
        {
            settingsmenu.Visible = !settingsmenu.Visible;
        }

        //Updates the timer on screen with currentTime
        private void DisplayCurrentTime() //Thomas Ocket
        {
            timedisplay.Text = currentTime.ToString(@"hh\:mm\:ss");
        }

        //Eventhandler for APPLY_TIMERS_BUTTON, updates the timer with the new set time values.
        private void APPLY_TIMERS_BUTTON_Click(object sender, EventArgs e) //Thomas Ocket
        {
            if (mode == "pause")
            {
                currentTime = new TimeSpan(pausetime.Value.Hour, pausetime.Value.Minute, pausetime.Value.Second);
            }
            else
            {
                currentTime = new TimeSpan(studytime.Value.Hour, studytime.Value.Minute, studytime.Value.Second);
            }
            DisplayCurrentTime();
        }

        //Eventhandler for AUTO_START_BREAK_CHECKBOX, when value changed update the settings
        private void AUTO_START_BREAK_CHECKBOX_CheckedChanged(object sender, EventArgs e) //Ricky Da Silva Marques
        {
            settingsApp.AutoStartBreak = AUTO_START_BREAK_CHECK.Checked;
        }

        //Eventhandler for AUTO_START_STUDY_CHECKBOX, when value changed update the settings
        private void AUTO_START_STUDY_CHECKBOX_CheckedChanged(object sender, EventArgs e) //Ricky Da Silva Marques
        {
            settingsApp.AutoStartStudy = AUTO_START_STUDY_CHECKBOX.Checked;
        }

        //Update the screen according to the mode and running state of the timer
        private void UpdateScreen() //Ricky Da Silva Marques
        {
            //Update LABEL_MODE
            if (mode == "study")
            {
                LABEL_MODE.Text = "Time to study!";
            }
            else
            {
                LABEL_MODE.Text = "Time for a break!";
            }

            //Update START_STOP_BUTTON displayed text
            if (!running)
            {
                clock.Stop();
                START_STOP_BUTTON.Text = "Start";
            }
            else
            {
                clock.Start();
                START_STOP_BUTTON.Text = "Stop";
            }
        }

        //Play notification sound
        private void PlaySound() //Ricky Da Silva Marques
        {
            using (var soundPlayer = new SoundPlayer(settingsApp.PathSound))
            {
                soundPlayer.Play(); 
            }
        }

        //Eventhandler for the studytime selector, change the settings to the set time.
        private void studytime_ValueChanged(object sender, EventArgs e) //Thomas Ocket
        {
            TimeSpan span = studytime.Value - new DateTime(1753, 1, 1);
            settingsApp.StudeerTijd = (int)span.TotalMinutes;
        }

        //Eventhandler for the pausetime selector, change the settings to the set time.
        private void pausetime_ValueChanged(object sender, EventArgs e) //Thomas Ocket
        {
            TimeSpan span = pausetime.Value - new DateTime(1753, 1, 1);
            settingsApp.PauzeTijd = (int)span.TotalMinutes;
        }

        //Eventhandler for SELECT_IMAGE, opens a file selector for a background image selector
        private void SELECT_IMAGE_Click(object sender, EventArgs e) //Ricky Da Silva Marques
        {
            //Open file selector
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //Set the search filters for the file selector and display
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();

            //When file is selected set the background image and save the path in settings
            if (openFileDialog1.FileName != "")
            { 
                settingsApp.PathImage = openFileDialog1.FileName;
                this.BackgroundImage = Image.FromFile(settingsApp.PathImage);

            }
           
        }

        //Eventhandler for SELECT_SOUND, opens a file selector for a notification sound selector
        private void SELECT_SOUND_Click(object sender, EventArgs e) //Ricky Da Silva Marques
        {
            //Open file selector
            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            //Set the search filters for the file selector and display
            openFileDialog2.Title = "Select File";
            openFileDialog2.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog2.Filter = "WAV (*.wav)|*.wav";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.ShowDialog();

            //When file is selected set the notification sound and save the path in settings
            if (openFileDialog2.FileName != "")
            {
                settingsApp.PathSound = openFileDialog2.FileName;
            }
 
        }

        //Clear the background image, revert to the default blue background. Also make the PathImage empty in the settings.
        private void CLEAR_BACKGROUND_Click(object sender, EventArgs e) //Ricky Da Silva Marques
        {
            settingsApp.PathImage = "";
            this.BackgroundImage = null;

        }

    }
}
