namespace Car
{
    partial class AddUserForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.garageLabel = new System.Windows.Forms.Label();
            this.carLabel = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.garageTextBox = new System.Windows.Forms.TextBox();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.birthDayTextBox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.AddCardButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.controlButton = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(103, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(103, 99);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(65, 17);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Surname";
            // 
            // garageLabel
            // 
            this.garageLabel.AutoSize = true;
            this.garageLabel.Location = new System.Drawing.Point(103, 137);
            this.garageLabel.Name = "garageLabel";
            this.garageLabel.Size = new System.Drawing.Size(56, 17);
            this.garageLabel.TabIndex = 2;
            this.garageLabel.Text = "Garage";
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Location = new System.Drawing.Point(103, 198);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(82, 17);
            this.carLabel.TabIndex = 3;
            this.carLabel.Text = "Car number";
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(103, 246);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(90, 17);
            this.cardLabel.TabIndex = 4;
            this.cardLabel.Text = "Card number";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(28, 430);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 53);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.UseWaitCursor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(265, 50);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(265, 99);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.surnameTextBox.TabIndex = 7;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.surnameTextBox_TextChanged);
            // 
            // garageTextBox
            // 
            this.garageTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.garageTextBox.Location = new System.Drawing.Point(265, 137);
            this.garageTextBox.MaxLength = 3;
            this.garageTextBox.Name = "garageTextBox";
            this.garageTextBox.Size = new System.Drawing.Size(100, 22);
            this.garageTextBox.TabIndex = 8;
            this.garageTextBox.TextChanged += new System.EventHandler(this.garageTextBox_TextChanged);
            this.garageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.garageTextBox_KeyPress);
            // 
            // carTextBox
            // 
            this.carTextBox.Location = new System.Drawing.Point(265, 198);
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.Size = new System.Drawing.Size(100, 22);
            this.carTextBox.TabIndex = 9;
            this.carTextBox.TextChanged += new System.EventHandler(this.carTextBox_TextChanged);
            // 
            // cardTextBox
            // 
            this.cardTextBox.Location = new System.Drawing.Point(265, 240);
            this.cardTextBox.MaxLength = 10;
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(100, 22);
            this.cardTextBox.TabIndex = 10;
            this.cardTextBox.TextChanged += new System.EventHandler(this.cardTextBox_TextChanged);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(106, 298);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(60, 17);
            this.birthdayLabel.TabIndex = 11;
            this.birthdayLabel.Text = "Birthday";
            // 
            // birthDayTextBox
            // 
            this.birthDayTextBox.Location = new System.Drawing.Point(265, 292);
            this.birthDayTextBox.Name = "birthDayTextBox";
            this.birthDayTextBox.ReadOnly = true;
            this.birthDayTextBox.Size = new System.Drawing.Size(100, 22);
            this.birthDayTextBox.TabIndex = 12;
            this.birthDayTextBox.TextChanged += new System.EventHandler(this.birthDayTextBox_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(496, 108);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // AddCardButton
            // 
            this.AddCardButton.Location = new System.Drawing.Point(213, 430);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(132, 53);
            this.AddCardButton.TabIndex = 14;
            this.AddCardButton.Text = "Добавить карту на гараж";
            this.AddCardButton.UseVisualStyleBackColor = true;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(405, 430);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(111, 53);
            this.settingsButton.TabIndex = 15;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // controlButton
            // 
            this.controlButton.Location = new System.Drawing.Point(574, 430);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(114, 53);
            this.controlButton.TabIndex = 16;
            this.controlButton.Text = "Управление";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(265, 166);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneTextBox.TabIndex = 17;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(106, 166);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(49, 17);
            this.phoneLabel.TabIndex = 18;
            this.phoneLabel.Text = "Phone";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 510);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.AddCardButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.birthDayTextBox);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.cardTextBox);
            this.Controls.Add(this.carTextBox);
            this.Controls.Add(this.garageTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.carLabel);
            this.Controls.Add(this.garageLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label garageLabel;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox garageTextBox;
        private System.Windows.Forms.TextBox carTextBox;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox birthDayTextBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button AddCardButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
    }
}