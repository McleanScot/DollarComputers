namespace DollarComputers
{
    partial class StartForm
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
            this.OrderLabel = new System.Windows.Forms.Label();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.SavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FinalPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FinalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Location = new System.Drawing.Point(65, 9);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(142, 13);
            this.OrderLabel.TabIndex = 0;
            this.OrderLabel.Text = "Order Your Computer Today!";
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Location = new System.Drawing.Point(76, 150);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(118, 23);
            this.NewOrderButton.TabIndex = 2;
            this.NewOrderButton.Text = "Start a New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // SavedOrderButton
            // 
            this.SavedOrderButton.Location = new System.Drawing.Point(76, 179);
            this.SavedOrderButton.Name = "SavedOrderButton";
            this.SavedOrderButton.Size = new System.Drawing.Size(118, 23);
            this.SavedOrderButton.TabIndex = 3;
            this.SavedOrderButton.Text = "Open a Saved Order";
            this.SavedOrderButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(76, 208);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(118, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FinalPictureBox
            // 
            this.FinalPictureBox.Image = global::DollarComputers.Properties.Resources._1080;
            this.FinalPictureBox.Location = new System.Drawing.Point(44, 25);
            this.FinalPictureBox.Name = "FinalPictureBox";
            this.FinalPictureBox.Size = new System.Drawing.Size(182, 119);
            this.FinalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FinalPictureBox.TabIndex = 1;
            this.FinalPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 248);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SavedOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.FinalPictureBox);
            this.Controls.Add(this.OrderLabel);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To Dollar Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.FinalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.PictureBox FinalPictureBox;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button SavedOrderButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

