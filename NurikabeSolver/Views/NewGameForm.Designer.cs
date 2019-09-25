namespace NurikabeSolver.Views
{
    partial class NewGameForm
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
            this.openButton = new System.Windows.Forms.Button();
            this.fromFileRadioButton = new System.Windows.Forms.RadioButton();
            this.fromUserRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(231, 72);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // fromFileRadioButton
            // 
            this.fromFileRadioButton.AutoSize = true;
            this.fromFileRadioButton.Checked = true;
            this.fromFileRadioButton.Location = new System.Drawing.Point(12, 12);
            this.fromFileRadioButton.Name = "fromFileRadioButton";
            this.fromFileRadioButton.Size = new System.Drawing.Size(83, 21);
            this.fromFileRadioButton.TabIndex = 1;
            this.fromFileRadioButton.TabStop = true;
            this.fromFileRadioButton.Text = "From file";
            this.fromFileRadioButton.UseVisualStyleBackColor = true;
            this.fromFileRadioButton.CheckedChanged += new System.EventHandler(this.fromFileRadioButton_CheckedChanged);
            // 
            // fromUserRadioButton
            // 
            this.fromUserRadioButton.AutoSize = true;
            this.fromUserRadioButton.Location = new System.Drawing.Point(12, 39);
            this.fromUserRadioButton.Name = "fromUserRadioButton";
            this.fromUserRadioButton.Size = new System.Drawing.Size(128, 21);
            this.fromUserRadioButton.TabIndex = 2;
            this.fromUserRadioButton.TabStop = true;
            this.fromUserRadioButton.Text = "From user input";
            this.fromUserRadioButton.UseVisualStyleBackColor = true;
            this.fromUserRadioButton.CheckedChanged += new System.EventHandler(this.fromUserRadioButton_CheckedChanged);
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(271, 38);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(35, 22);
            this.sizeTextBox.TabIndex = 3;
            this.sizeTextBox.Visible = false;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(226, 41);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(39, 17);
            this.sizeLabel.TabIndex = 4;
            this.sizeLabel.Text = "Size:";
            this.sizeLabel.Visible = false;
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 107);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.fromUserRadioButton);
            this.Controls.Add(this.fromFileRadioButton);
            this.Controls.Add(this.openButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGameForm";
            this.Text = "New game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.RadioButton fromFileRadioButton;
        private System.Windows.Forms.RadioButton fromUserRadioButton;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Label sizeLabel;
    }
}