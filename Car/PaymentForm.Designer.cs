using Car.Model;
using System.Linq;

namespace Car
{
    partial class PaymentForm
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
            this.garageComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.surnameLabel1 = new System.Windows.Forms.Label();
            this.moneyLabel1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.makePaymentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // garageComboBox
            // 
            this.garageComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.garageComboBox.FormattingEnabled = true;
            this.garageComboBox.Location = new System.Drawing.Point(115, 16);
            this.garageComboBox.MaxDropDownItems = 20;
            this.garageComboBox.Name = "garageComboBox";
            this.garageComboBox.Size = new System.Drawing.Size(121, 24);
            this.garageComboBox.Sorted = true;
            this.garageComboBox.TabIndex = 0;
            this.garageComboBox.SelectedIndexChanged += new System.EventHandler(this.garageComboBox_SelectedIndexChanged);
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Location = new System.Drawing.Point(12, 57);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(35, 17);
            this.nameLabel1.TabIndex = 1;
            this.nameLabel1.Text = "Имя";
            // 
            // surnameLabel1
            // 
            this.surnameLabel1.AutoSize = true;
            this.surnameLabel1.Location = new System.Drawing.Point(12, 99);
            this.surnameLabel1.Name = "surnameLabel1";
            this.surnameLabel1.Size = new System.Drawing.Size(70, 17);
            this.surnameLabel1.TabIndex = 2;
            this.surnameLabel1.Text = "Фамилия";
            // 
            // moneyLabel1
            // 
            this.moneyLabel1.AutoSize = true;
            this.moneyLabel1.Location = new System.Drawing.Point(12, 142);
            this.moneyLabel1.Name = "moneyLabel1";
            this.moneyLabel1.Size = new System.Drawing.Size(56, 17);
            this.moneyLabel1.TabIndex = 3;
            this.moneyLabel1.Text = "Баланс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Сумма";
            // 
            // payTextBox
            // 
            this.payTextBox.Location = new System.Drawing.Point(118, 176);
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.Size = new System.Drawing.Size(118, 22);
            this.payTextBox.TabIndex = 5;
            this.payTextBox.TextChanged += new System.EventHandler(this.payTextBox_TextChanged);
            // 
            // makePaymentButton
            // 
            this.makePaymentButton.Location = new System.Drawing.Point(77, 257);
            this.makePaymentButton.Name = "makePaymentButton";
            this.makePaymentButton.Size = new System.Drawing.Size(138, 33);
            this.makePaymentButton.TabIndex = 6;
            this.makePaymentButton.Text = "Оплатить";
            this.makePaymentButton.UseVisualStyleBackColor = true;
            this.makePaymentButton.Click += new System.EventHandler(this.makePaymentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Гараж";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(115, 56);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 17);
            this.nameLabel.TabIndex = 8;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(115, 99);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(0, 17);
            this.surnameLabel.TabIndex = 9;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(115, 141);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(0, 17);
            this.moneyLabel.TabIndex = 10;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 339);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makePaymentButton);
            this.Controls.Add(this.payTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.moneyLabel1);
            this.Controls.Add(this.surnameLabel1);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.garageComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Внести средства";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox garageComboBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label surnameLabel1;
        private System.Windows.Forms.Label moneyLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox payTextBox;
        private System.Windows.Forms.Button makePaymentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label moneyLabel;
    }
}