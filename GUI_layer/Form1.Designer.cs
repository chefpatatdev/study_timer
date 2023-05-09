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
            this.settingsmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timedisplay
            // 
            this.timedisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timedisplay.AutoSize = true;
            this.timedisplay.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timedisplay.ForeColor = System.Drawing.Color.Transparent;
            this.timedisplay.Location = new System.Drawing.Point(301, 161);
            this.timedisplay.Name = "timedisplay";
            this.timedisplay.Size = new System.Drawing.Size(326, 95);
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
            this.startstop.Location = new System.Drawing.Point(414, 286);
            this.startstop.Name = "startstop";
            this.startstop.Size = new System.Drawing.Size(75, 23);
            this.startstop.TabIndex = 1;
            this.startstop.Text = "start";
            this.startstop.UseVisualStyleBackColor = true;
            this.startstop.Click += new System.EventHandler(this.startstop_Click);
            // 
            // studytime
            // 
            this.studytime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.studytime.Location = new System.Drawing.Point(0, 15);
            this.studytime.Name = "studytime";
            this.studytime.ShowUpDown = true;
            this.studytime.Size = new System.Drawing.Size(89, 20);
            this.studytime.TabIndex = 2;
            this.studytime.Value = new System.DateTime(1753, 1, 1, 0, 0, 5, 0);
            // 
            // pausetime
            // 
            this.pausetime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pausetime.Location = new System.Drawing.Point(0, 40);
            this.pausetime.Name = "pausetime";
            this.pausetime.ShowUpDown = true;
            this.pausetime.Size = new System.Drawing.Size(89, 20);
            this.pausetime.TabIndex = 3;
            this.pausetime.Value = new System.DateTime(1753, 1, 1, 0, 0, 2, 0);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Location = new System.Drawing.Point(912, 0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(75, 23);
            this.settings.TabIndex = 4;
            this.settings.Text = "settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // settingsmenu
            // 
            this.settingsmenu.Controls.Add(this.confirmsettings);
            this.settingsmenu.Controls.Add(this.pausetime);
            this.settingsmenu.Controls.Add(this.studytime);
            this.settingsmenu.Location = new System.Drawing.Point(885, 29);
            this.settingsmenu.Name = "settingsmenu";
            this.settingsmenu.Size = new System.Drawing.Size(102, 210);
            this.settingsmenu.TabIndex = 5;
            this.settingsmenu.TabStop = false;
            this.settingsmenu.Text = "settings";
            this.settingsmenu.Visible = false;
            // 
            // confirmsettings
            // 
            this.confirmsettings.Location = new System.Drawing.Point(6, 179);
            this.confirmsettings.Name = "confirmsettings";
            this.confirmsettings.Size = new System.Drawing.Size(75, 23);
            this.confirmsettings.TabIndex = 4;
            this.confirmsettings.Text = "apply";
            this.confirmsettings.UseVisualStyleBackColor = true;
            this.confirmsettings.Click += new System.EventHandler(this.confirmsettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.settingsmenu);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.startstop);
            this.Controls.Add(this.timedisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.settingsmenu.ResumeLayout(false);
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
    }
}

