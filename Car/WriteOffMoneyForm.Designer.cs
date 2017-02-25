namespace Car
{
    partial class WriteOffMoneyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.writeOffSumTextBox = new System.Windows.Forms.TextBox();
            this.writeOffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Платеж";
            // 
            // writeOffSumTextBox
            // 
            this.writeOffSumTextBox.Location = new System.Drawing.Point(133, 44);
            this.writeOffSumTextBox.Name = "writeOffSumTextBox";
            this.writeOffSumTextBox.Size = new System.Drawing.Size(100, 22);
            this.writeOffSumTextBox.TabIndex = 1;
            this.writeOffSumTextBox.TextChanged += new System.EventHandler(this.writeOffSumTextBox_TextChanged);
            // 
            // writeOffButton
            // 
            this.writeOffButton.Location = new System.Drawing.Point(133, 134);
            this.writeOffButton.Name = "writeOffButton";
            this.writeOffButton.Size = new System.Drawing.Size(100, 58);
            this.writeOffButton.TabIndex = 2;
            this.writeOffButton.Text = "Списать средства";
            this.writeOffButton.UseVisualStyleBackColor = true;
            this.writeOffButton.Click += new System.EventHandler(this.writeOffButton_Click);
            // 
            // WriteOffMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 261);
            this.Controls.Add(this.writeOffButton);
            this.Controls.Add(this.writeOffSumTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WriteOffMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Списание средств";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox writeOffSumTextBox;
        private System.Windows.Forms.Button writeOffButton;
    }
}