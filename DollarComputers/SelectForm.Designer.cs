namespace DollarComputers
{
    partial class SelectForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.HardwareDataGridView = new System.Windows.Forms.DataGridView();
            this.YourSelectionLabed = new System.Windows.Forms.Label();
            this.YourSelectionTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HardwareDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(13, 13);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(188, 13);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Please Select Your Desired Hardware:";
            // 
            // HardwareDataGridView
            // 
            this.HardwareDataGridView.AllowUserToAddRows = false;
            this.HardwareDataGridView.AllowUserToDeleteRows = false;
            this.HardwareDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HardwareDataGridView.Location = new System.Drawing.Point(13, 30);
            this.HardwareDataGridView.Name = "HardwareDataGridView";
            this.HardwareDataGridView.ReadOnly = true;
            this.HardwareDataGridView.Size = new System.Drawing.Size(746, 345);
            this.HardwareDataGridView.TabIndex = 1;
            // 
            // YourSelectionLabed
            // 
            this.YourSelectionLabed.AutoSize = true;
            this.YourSelectionLabed.Location = new System.Drawing.Point(10, 403);
            this.YourSelectionLabed.Name = "YourSelectionLabed";
            this.YourSelectionLabed.Size = new System.Drawing.Size(188, 13);
            this.YourSelectionLabed.TabIndex = 2;
            this.YourSelectionLabed.Text = "Please Select Your Desired Hardware:";
            // 
            // YourSelectionTextBox
            // 
            this.YourSelectionTextBox.Location = new System.Drawing.Point(204, 400);
            this.YourSelectionTextBox.Name = "YourSelectionTextBox";
            this.YourSelectionTextBox.Size = new System.Drawing.Size(354, 20);
            this.YourSelectionTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(596, 400);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(677, 400);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 439);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.YourSelectionTextBox);
            this.Controls.Add(this.YourSelectionLabed);
            this.Controls.Add(this.HardwareDataGridView);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "SelectForm";
            this.Text = "Buil Your Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.HardwareDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.DataGridView HardwareDataGridView;
        private System.Windows.Forms.Label YourSelectionLabed;
        private System.Windows.Forms.TextBox YourSelectionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}