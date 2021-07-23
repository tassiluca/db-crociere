
namespace db_crociere
{
    partial class Main
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
            this.splashScreen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // splashScreen
            // 
            this.splashScreen.BackgroundImage = global::db_crociere.Properties.Resources.splash_screen;
            this.splashScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splashScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splashScreen.Location = new System.Drawing.Point(0, 0);
            this.splashScreen.Name = "splashScreen";
            this.splashScreen.Size = new System.Drawing.Size(644, 370);
            this.splashScreen.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(644, 370);
            this.Controls.Add(this.splashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.SplashScreen_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel splashScreen;
    }
}

