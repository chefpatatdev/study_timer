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
            this.confirmsettings = new System.Windows.Forms.Button();
            this.AUTO_START_BREAK_CHECK = new System.Windows.Forms.CheckBox();
            this.AUTO_START_STUDY_CHECKBOX = new System.Windows.Forms.CheckBox();
            this.settingsmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timedisplay
            // 
            this.timedisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timedisplay.AutoSize = true;
            this.timedisplay.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timedisplay.ForeColor = System.Drawing.Color.Transparent;
            this.timedisplay.Location = new System.Drawing.Point(401, 198);
            this.timedisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timedisplay.Name = "timedisplay";
            this.timedisplay.Size = new System.Drawing.Size(406, 117);
            this.timedisplay.TabIndex = 0;
            this.timedisplay.Text = "00:00:00";
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // startstop
            // 
            this.startstop.Location = new System.Drawing.Point(552, 352);
            this.startstop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startstop.Name = "startstop";
            this.startstop.Size = new System.Drawing.Size(100, 28);
            this.startstop.TabIndex = 1;
            this.startstop.Text = "start";
            this.startstop.UseVisualStyleBackColor = true;
            this.startstop.Click += new System.EventHandler(this.startstop_Click);
            // 
            // studytime
            // 
            this.studytime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.studytime.Location = new System.Drawing.Point(8, 18);
            this.studytime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studytime.Name = "studytime";
            this.studytime.ShowUpDown = true;
            this.studytime.Size = new System.Drawing.Size(120, 22);
            this.studytime.TabIndex = 2;
            this.studytime.Value = new System.DateTime(1753, 1, 1, 0, 0, 5, 0);
            // 
            // pausetime
            // 
            this.pausetime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pausetime.Location = new System.Drawing.Point(8, 48);
            this.pausetime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pausetime.Name = "pausetime";
            this.pausetime.ShowUpDown = true;
            this.pausetime.Size = new System.Drawing.Size(120, 22);
            this.pausetime.TabIndex = 3;
            this.pausetime.Value = new System.DateTime(1753, 1, 1, 0, 0, 2, 0);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Location = new System.Drawing.Point(1216, 0);
            this.settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(100, 28);
            this.settings.TabIndex = 4;
            this.settings.Text = "settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // settingsmenu
            // 
            this.settingsmenu.Controls.Add(this.AUTO_START_STUDY_CHECKBOX);
            this.settingsmenu.Controls.Add(this.AUTO_START_BREAK_CHECK);
            this.settingsmenu.Controls.Add(this.confirmsettings);
            this.settingsmenu.Controls.Add(this.pausetime);
            this.settingsmenu.Controls.Add(this.studytime);
            this.settingsmenu.Location = new System.Drawing.Point(1173, 36);
            this.settingsmenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsmenu.Name = "settingsmenu";
            this.settingsmenu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsmenu.Size = new System.Drawing.Size(143, 258);
            this.settingsmenu.TabIndex = 5;
            this.settingsmenu.TabStop = false;
            this.settingsmenu.Text = "settings";
            this.settingsmenu.Visible = false;
            this.settingsmenu.Enter += new System.EventHandler(this.settingsmenu_Enter);
            // 
            // confirmsettings
            // 
            this.confirmsettings.Location = new System.Drawing.Point(8, 220);
            this.confirmsettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmsettings.Name = "confirmsettings";
            this.confirmsettings.Size = new System.Drawing.Size(100, 28);
            this.confirmsettings.TabIndex = 4;
            this.confirmsettings.Text = "apply";
            this.confirmsettings.UseVisualStyleBackColor = true;
            this.confirmsettings.Click += new System.EventHandler(this.confirmsettings_Click);
            // 
            // AUTO_START_BREAK_CHECK
            // 
            this.AUTO_START_BREAK_CHECK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AUTO_START_BREAK_CHECK.AutoSize = true;
            this.AUTO_START_BREAK_CHECK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AUTO_START_BREAK_CHECK.Location = new System.Drawing.Point(15, 78);
            this.AUTO_START_BREAK_CHECK.Name = "AUTO_START_BREAK_CHECK";
            this.AUTO_START_BREAK_CHECK.Size = new System.Drawing.Size(122, 20);
            this.AUTO_START_BREAK_CHECK.TabIndex = 5;
            this.AUTO_START_BREAK_CHECK.Text = "Auto start break";
            this.AUTO_START_BREAK_CHECK.UseVisualStyleBackColor = true;
            this.AUTO_START_BREAK_CHECK.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AUTO_START_STUDY_CHECKBOX
            // 
            this.AUTO_START_STUDY_CHECKBOX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AUTO_START_STUDY_CHECKBOX.AutoSize = true;
            this.AUTO_START_STUDY_CHECKBOX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AUTO_START_STUDY_CHECKBOX.Location = new System.Drawing.Point(18, 104);
            this.AUTO_START_STUDY_CHECKBOX.Name = "AUTO_START_STUDY_CHECKBOX";
            this.AUTO_START_STUDY_CHECKBOX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AUTO_START_STUDY_CHECKBOX.Size = new System.Drawing.Size(119, 20);
            this.AUTO_START_STUDY_CHECKBOX.TabIndex = 6;
            this.AUTO_START_STUDY_CHECKBOX.Text = "Auto start study";
            this.AUTO_START_STUDY_CHECKBOX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AUTO_START_STUDY_CHECKBOX.UseVisualStyleBackColor = true;
            this.AUTO_START_STUDY_CHECKBOX.CheckedChanged += new System.EventHandler(this.AUTO_START_STUDY_CHECKBOX_CheckedChanged);
            // 
            // GUI_studytimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1312, 567);
            this.Controls.Add(this.settingsmenu);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.startstop);
            this.Controls.Add(this.timedisplay);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUI_studytimer";
            this.Text = "Form1";
            this.TopMost = true;
            this.settingsmenu.ResumeLayout(false);
            this.settingsmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

