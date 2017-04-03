namespace DollarComputers
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.SplashScreenPictureBox = new System.Windows.Forms.PictureBox();
            this.SplashFromTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashScreenPictureBox
            // 
            this.SplashScreenPictureBox.Image = global::DollarComputers.Properties.Resources.computer;
            this.SplashScreenPictureBox.Location = new System.Drawing.Point(13, 13);
            this.SplashScreenPictureBox.Name = "SplashScreenPictureBox";
            this.SplashScreenPictureBox.Size = new System.Drawing.Size(259, 236);
            this.SplashScreenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SplashScreenPictureBox.TabIndex = 0;
            this.SplashScreenPictureBox.TabStop = false;
            // 
            // SplashFromTimer
            // 
            this.SplashFromTimer.Enabled = true;
            this.SplashFromTimer.Interval = 3000;
            this.SplashFromTimer.Tick += new System.EventHandler(this.SplashFromTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.SplashScreenPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreenPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashScreenPictureBox;
        private System.Windows.Forms.Timer SplashFromTimer;
    }
}