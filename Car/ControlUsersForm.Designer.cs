namespace Car
{
    partial class ControlUsersForm
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
            this.addPaymentButton = new System.Windows.Forms.Button();
            this.writeOffButton = new System.Windows.Forms.Button();
            this.showAllWriteOffButton = new System.Windows.Forms.Button();
            this.allGarageInfoButton = new System.Windows.Forms.Button();
            this.showPaymentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPaymentButton
            // 
            this.addPaymentButton.Location = new System.Drawing.Point(66, 57);
            this.addPaymentButton.Name = "addPaymentButton";
            this.addPaymentButton.Size = new System.Drawing.Size(104, 60);
            this.addPaymentButton.TabIndex = 0;
            this.addPaymentButton.Text = "Добавить оплату";
            this.addPaymentButton.UseVisualStyleBackColor = true;
            this.addPaymentButton.Click += new System.EventHandler(this.addPaymentButton_Click);
            // 
            // writeOffButton
            // 
            this.writeOffButton.Location = new System.Drawing.Point(221, 57);
            this.writeOffButton.Name = "writeOffButton";
            this.writeOffButton.Size = new System.Drawing.Size(115, 60);
            this.writeOffButton.TabIndex = 1;
            this.writeOffButton.Text = "Списать средства";
            this.writeOffButton.UseVisualStyleBackColor = true;
            this.writeOffButton.Click += new System.EventHandler(this.writeOffButton_Click);
            // 
            // showAllWriteOffButton
            // 
            this.showAllWriteOffButton.Location = new System.Drawing.Point(386, 57);
            this.showAllWriteOffButton.Name = "showAllWriteOffButton";
            this.showAllWriteOffButton.Size = new System.Drawing.Size(110, 60);
            this.showAllWriteOffButton.TabIndex = 2;
            this.showAllWriteOffButton.Text = "Просмотр списаний";
            this.showAllWriteOffButton.UseVisualStyleBackColor = true;
            this.showAllWriteOffButton.Click += new System.EventHandler(this.showAllWriteOffButton_Click);
            // 
            // allGarageInfoButton
            // 
            this.allGarageInfoButton.Location = new System.Drawing.Point(66, 162);
            this.allGarageInfoButton.Name = "allGarageInfoButton";
            this.allGarageInfoButton.Size = new System.Drawing.Size(104, 59);
            this.allGarageInfoButton.TabIndex = 3;
            this.allGarageInfoButton.Text = "Все гаражи";
            this.allGarageInfoButton.UseVisualStyleBackColor = true;
            this.allGarageInfoButton.Click += new System.EventHandler(this.allGarageInfoButton_Click);
            // 
            // showPaymentsButton
            // 
            this.showPaymentsButton.Location = new System.Drawing.Point(386, 162);
            this.showPaymentsButton.Name = "showPaymentsButton";
            this.showPaymentsButton.Size = new System.Drawing.Size(110, 59);
            this.showPaymentsButton.TabIndex = 5;
            this.showPaymentsButton.Text = "Полная информация о гараже";
            this.showPaymentsButton.UseVisualStyleBackColor = true;
            this.showPaymentsButton.Click += new System.EventHandler(this.showPaymentsButton_Click);
            // 
            // ControlUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 260);
            this.Controls.Add(this.showPaymentsButton);
            this.Controls.Add(this.allGarageInfoButton);
            this.Controls.Add(this.showAllWriteOffButton);
            this.Controls.Add(this.writeOffButton);
            this.Controls.Add(this.addPaymentButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ControlUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPaymentButton;
        private System.Windows.Forms.Button writeOffButton;
        private System.Windows.Forms.Button showAllWriteOffButton;
        private System.Windows.Forms.Button allGarageInfoButton;
        private System.Windows.Forms.Button showPaymentsButton;
    }
}