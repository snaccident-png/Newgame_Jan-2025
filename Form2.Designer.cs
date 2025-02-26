namespace Snaccident_Dog_attempt_one_06_January_2025
{
    partial class splashScreenSD
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerSD = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.AccessibleDescription = "Currently loading a desktop game named Snaccident Dog, version 1.";
            this.progressBar.AccessibleName = "Splash screen for Snaccident Dog, version 1, by Nathan Tries To Make Games.";
            this.progressBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.progressBar.BackColor = System.Drawing.Color.RosyBrown;
            this.progressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(12, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(960, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 0;
            // 
            // timerSD
            // 
            this.timerSD.Enabled = true;
            this.timerSD.Tick += new System.EventHandler(this.TimerStop);
            // 
            // splashScreenSD
            // 
            this.AccessibleDescription = "Currently loading a desktop game named Snaccident Dog, version 1.";
            this.AccessibleName = "Splash screen for Snaccident Dog, version 1, by Nathan Tries To Make Games.";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snaccident_Dog_attempt_one_06_January_2025.Properties.Resources.Splash_screen_graphic_for_SD_version_1_Nearest_neighbour_mode_12_February_2025;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 495);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar);
            this.Name = "splashScreenSD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash screen for Snaccident Dog";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerSD;
    }
}