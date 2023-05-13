using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_layer
{
    partial class GUI_studytimer
    {
/// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timedisplay = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.startstop = new System.Windows.Forms.Button();
            this.studytime = new System.Windows.Forms.DateTimePicker();
            this.pausetime = new System.Windows.Forms.DateTimePicker();
            this.settings = new System.Windows.Forms.Button();
            this.settingsmenu = new System.Windows.Forms.GroupBox();
            this.SELECT_SOUND = new System.Windows.Forms.Button();
            this.SELECT_IMAGE_BUTTON = new System.Windows.Forms.Button();
            this.AUTO_START_STUDY_CHECKBOX = new System.Windows.Forms.CheckBox();
            this.AUTO_START_BREAK_CHECK = new System.Windows.Forms.CheckBox();
            this.confirmsettings = new System.Windows.Forms.Button();
            this.CLEAR_BACKGROUND = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timedisplay
            // 
            this.timedisplay.BackColor = System.Drawing.Color.Transparent;
            this.timedisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timedisplay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timedisplay.ForeColor = System.Drawing.Color.Transparent;
            this.timedisplay.Location = new System.Drawing.Point(0, 0);
            this.timedisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timedisplay.Name = "timedisplay";
            this.timedisplay.Size = new System.Drawing.Size(1312, 602);
            this.timedisplay.TabIndex = 0;
            this.timedisplay.Text = "00:00:00";
            this.timedisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timedisplay.Click += new System.EventHandler(this.timedisplay_Click);
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // startstop
            // 
            this.startstop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.startstop.FlatAppearance.BorderSize = 5;
            this.startstop.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startstop.Location = new System.Drawing.Point(592, 382);
            this.startstop.Margin = new System.Windows.Forms.Padding(4);
            this.startstop.Name = "startstop";
            this.startstop.Size = new System.Drawing.Size(123, 45);
            this.startstop.TabIndex = 1;
            this.startstop.Text = "Start";
            this.startstop.UseVisualStyleBackColor = true;
            this.startstop.Click += new System.EventHandler(this.startstop_Click);
            // 
            // studytime
            // 
            this.studytime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.studytime.Location = new System.Drawing.Point(5, 19);
            this.studytime.Margin = new System.Windows.Forms.Padding(4);
            this.studytime.Name = "studytime";
            this.studytime.ShowUpDown = true;
            this.studytime.Size = new System.Drawing.Size(123, 25);
            this.studytime.TabIndex = 2;
            this.studytime.Value = new System.DateTime(1753, 1, 1, 0, 0, 5, 0);
            // 
            // pausetime
            // 
            this.pausetime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pausetime.Location = new System.Drawing.Point(5, 51);
            this.pausetime.Margin = new System.Windows.Forms.Padding(4);
            this.pausetime.Name = "pausetime";
            this.pausetime.ShowUpDown = true;
            this.pausetime.Size = new System.Drawing.Size(123, 25);
            this.pausetime.TabIndex = 3;
            this.pausetime.Value = new System.DateTime(1753, 1, 1, 0, 0, 2, 0);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Location = new System.Drawing.Point(1216, 0);
            this.settings.Margin = new System.Windows.Forms.Padding(4);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(100, 30);
            this.settings.TabIndex = 4;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // settingsmenu
            // 
            this.settingsmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsmenu.BackColor = System.Drawing.Color.Transparent;
            this.settingsmenu.Controls.Add(this.CLEAR_BACKGROUND);
            this.settingsmenu.Controls.Add(this.SELECT_SOUND);
            this.settingsmenu.Controls.Add(this.SELECT_IMAGE_BUTTON);
            this.settingsmenu.Controls.Add(this.AUTO_START_STUDY_CHECKBOX);
            this.settingsmenu.Controls.Add(this.AUTO_START_BREAK_CHECK);
            this.settingsmenu.Controls.Add(this.confirmsettings);
            this.settingsmenu.Controls.Add(this.pausetime);
            this.settingsmenu.Controls.Add(this.studytime);
            this.settingsmenu.Location = new System.Drawing.Point(1163, 38);
            this.settingsmenu.Margin = new System.Windows.Forms.Padding(4);
            this.settingsmenu.Name = "settingsmenu";
            this.settingsmenu.Padding = new System.Windows.Forms.Padding(4);
            this.settingsmenu.Size = new System.Drawing.Size(153, 286);
            this.settingsmenu.TabIndex = 5;
            this.settingsmenu.TabStop = false;
            this.settingsmenu.Text = "Settings";
            this.settingsmenu.Visible = false;
            this.settingsmenu.Enter += new System.EventHandler(this.settingsmenu_Enter);
            // 
            // SELECT_SOUND
            // 
            this.SELECT_SOUND.Location = new System.Drawing.Point(7, 172);
            this.SELECT_SOUND.Name = "SELECT_SOUND";
            this.SELECT_SOUND.Size = new System.Drawing.Size(123, 28);
            this.SELECT_SOUND.TabIndex = 8;
            this.SELECT_SOUND.Text = "Select sound";
            this.SELECT_SOUND.UseVisualStyleBackColor = true;
            this.SELECT_SOUND.Click += new System.EventHandler(this.SELECT_SOUND_Click);
            // 
            // SELECT_IMAGE_BUTTON
            // 
            this.SELECT_IMAGE_BUTTON.Location = new System.Drawing.Point(7, 138);
            this.SELECT_IMAGE_BUTTON.Name = "SELECT_IMAGE_BUTTON";
            this.SELECT_IMAGE_BUTTON.Size = new System.Drawing.Size(123, 28);
            this.SELECT_IMAGE_BUTTON.TabIndex = 7;
            this.SELECT_IMAGE_BUTTON.Text = "Select image";
            this.SELECT_IMAGE_BUTTON.UseVisualStyleBackColor = true;
            this.SELECT_IMAGE_BUTTON.Click += new System.EventHandler(this.button1_Click);
            // 
            // AUTO_START_STUDY_CHECKBOX
            // 
            this.AUTO_START_STUDY_CHECKBOX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AUTO_START_STUDY_CHECKBOX.AutoSize = true;
            this.AUTO_START_STUDY_CHECKBOX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AUTO_START_STUDY_CHECKBOX.Location = new System.Drawing.Point(0, 110);
            this.AUTO_START_STUDY_CHECKBOX.Name = "AUTO_START_STUDY_CHECKBOX";
            this.AUTO_START_STUDY_CHECKBOX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AUTO_START_STUDY_CHECKBOX.Size = new System.Drawing.Size(130, 21);
            this.AUTO_START_STUDY_CHECKBOX.TabIndex = 6;
            this.AUTO_START_STUDY_CHECKBOX.Text = "Auto start study";
            this.AUTO_START_STUDY_CHECKBOX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AUTO_START_STUDY_CHECKBOX.UseVisualStyleBackColor = true;
            this.AUTO_START_STUDY_CHECKBOX.CheckedChanged += new System.EventHandler(this.AUTO_START_STUDY_CHECKBOX_CheckedChanged);
            // 
            // AUTO_START_BREAK_CHECK
            // 
            this.AUTO_START_BREAK_CHECK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AUTO_START_BREAK_CHECK.AutoSize = true;
            this.AUTO_START_BREAK_CHECK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AUTO_START_BREAK_CHECK.Location = new System.Drawing.Point(0, 82);
            this.AUTO_START_BREAK_CHECK.Name = "AUTO_START_BREAK_CHECK";
            this.AUTO_START_BREAK_CHECK.Size = new System.Drawing.Size(130, 21);
            this.AUTO_START_BREAK_CHECK.TabIndex = 5;
            this.AUTO_START_BREAK_CHECK.Text = "Auto start break";
            this.AUTO_START_BREAK_CHECK.UseVisualStyleBackColor = true;
            this.AUTO_START_BREAK_CHECK.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // confirmsettings
            // 
            this.confirmsettings.Location = new System.Drawing.Point(8, 241);
            this.confirmsettings.Margin = new System.Windows.Forms.Padding(4);
            this.confirmsettings.Name = "confirmsettings";
            this.confirmsettings.Size = new System.Drawing.Size(122, 36);
            this.confirmsettings.TabIndex = 4;
            this.confirmsettings.Text = "Apply";
            this.confirmsettings.UseVisualStyleBackColor = true;
            this.confirmsettings.Click += new System.EventHandler(this.confirmsettings_Click);
            // 
            // CLEAR_BACKGROUND
            // 
            this.CLEAR_BACKGROUND.Location = new System.Drawing.Point(7, 206);
            this.CLEAR_BACKGROUND.Name = "CLEAR_BACKGROUND";
            this.CLEAR_BACKGROUND.Size = new System.Drawing.Size(123, 28);
            this.CLEAR_BACKGROUND.TabIndex = 9;
            this.CLEAR_BACKGROUND.Text = "Clear background";
            this.CLEAR_BACKGROUND.UseVisualStyleBackColor = true;
            this.CLEAR_BACKGROUND.Click += new System.EventHandler(this.CLEAR_BACKGROUND_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(545, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "hier meot studyblocks met #";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(545, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hier komt of het \"Break\" of Study\" is";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GUI_studytimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsmenu);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.startstop);
            this.Controls.Add(this.timedisplay);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_studytimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudyTimer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_studytimer_Load);
            this.settingsmenu.ResumeLayout(false);
            this.settingsmenu.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Label timedisplay;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button startstop;
        private System.Windows.Forms.DateTimePicker studytime;
        private System.Windows.Forms.DateTimePicker pausetime;
        private Button settings;
        private GroupBox settingsmenu;
        private Button confirmsettings;
        private CheckBox AUTO_START_BREAK_CHECK;
        private CheckBox AUTO_START_STUDY_CHECKBOX;
        private Button SELECT_IMAGE_BUTTON;
        private Button SELECT_SOUND;
        private Button CLEAR_BACKGROUND;
        private Label label1;
        private Label label2;
    }
}

