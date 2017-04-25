namespace Car
{
    partial class AllAboutUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.phoneLlabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.paymentsGridView = new System.Windows.Forms.DataGridView();
            this.cardsGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.entrancesDataGrid = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrancesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // garageComboBox
            // 
            this.garageComboBox.FormattingEnabled = true;
            this.garageComboBox.Location = new System.Drawing.Point(183, 12);
            this.garageComboBox.Name = "garageComboBox";
            this.garageComboBox.Size = new System.Drawing.Size(150, 24);
            this.garageComboBox.TabIndex = 0;
            this.garageComboBox.SelectedIndexChanged += new System.EventHandler(this.garageComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Гараж";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(45, 62);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 17);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(45, 107);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(70, 17);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Фамилия";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(45, 147);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(53, 17);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Статус";
            // 
            // phoneLlabel
            // 
            this.phoneLlabel.AutoSize = true;
            this.phoneLlabel.Location = new System.Drawing.Point(45, 189);
            this.phoneLlabel.Name = "phoneLlabel";
            this.phoneLlabel.Size = new System.Drawing.Size(84, 17);
            this.phoneLlabel.TabIndex = 5;
            this.phoneLlabel.Text = "Моб. номер";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(45, 297);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(56, 17);
            this.balanceLabel.TabIndex = 6;
            this.balanceLabel.Text = "Баланс";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(183, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 22);
            this.nameTextBox.TabIndex = 7;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(183, 101);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(150, 22);
            this.surnameTextBox.TabIndex = 8;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(183, 147);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(150, 22);
            this.statusTextBox.TabIndex = 9;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(183, 183);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(150, 22);
            this.phoneTextBox.TabIndex = 10;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(183, 291);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(150, 22);
            this.balanceTextBox.TabIndex = 11;
            // 
            // paymentsGridView
            // 
            this.paymentsGridView.AllowUserToAddRows = false;
            this.paymentsGridView.AllowUserToDeleteRows = false;
            this.paymentsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.paymentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.price});
            this.paymentsGridView.Location = new System.Drawing.Point(46, 364);
            this.paymentsGridView.Name = "paymentsGridView";
            this.paymentsGridView.RowHeadersVisible = false;
            this.paymentsGridView.RowHeadersWidth = 4;
            this.paymentsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.paymentsGridView.RowTemplate.Height = 24;
            this.paymentsGridView.Size = new System.Drawing.Size(250, 150);
            this.paymentsGridView.TabIndex = 13;
            // 
            // cardsGridView
            // 
            this.cardsGridView.AllowUserToAddRows = false;
            this.cardsGridView.AllowUserToDeleteRows = false;
            this.cardsGridView.AllowUserToResizeColumns = false;
            this.cardsGridView.AllowUserToResizeRows = false;
            this.cardsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardId});
            this.cardsGridView.Location = new System.Drawing.Point(315, 364);
            this.cardsGridView.Name = "cardsGridView";
            this.cardsGridView.ReadOnly = true;
            this.cardsGridView.RowHeadersVisible = false;
            this.cardsGridView.RowTemplate.Height = 24;
            this.cardsGridView.Size = new System.Drawing.Size(250, 150);
            this.cardsGridView.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(315, 549);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(250, 52);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "День рождения";
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Location = new System.Drawing.Point(183, 235);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.ReadOnly = true;
            this.birthdayTextBox.Size = new System.Drawing.Size(150, 22);
            this.birthdayTextBox.TabIndex = 18;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(373, 107);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // entrancesDataGrid
            // 
            this.entrancesDataGrid.AllowUserToAddRows = false;
            this.entrancesDataGrid.AllowUserToDeleteRows = false;
            this.entrancesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.entrancesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.entryCount});
            this.entrancesDataGrid.Location = new System.Drawing.Point(584, 364);
            this.entrancesDataGrid.Name = "entrancesDataGrid";
            this.entrancesDataGrid.ReadOnly = true;
            this.entrancesDataGrid.RowHeadersVisible = false;
            this.entrancesDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.entrancesDataGrid.RowTemplate.Height = 24;
            this.entrancesDataGrid.Size = new System.Drawing.Size(250, 150);
            this.entrancesDataGrid.TabIndex = 20;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            // 
            // price
            // 
            this.price.HeaderText = "Сумма";
            this.price.Name = "price";
            this.price.Width = 85;
            // 
            // cardId
            // 
            this.cardId.HeaderText = "Номер карты";
            this.cardId.Name = "cardId";
            this.cardId.ReadOnly = true;
            this.cardId.Width = 185;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // entryCount
            // 
            this.entryCount.HeaderText = "Заездов";
            this.entryCount.Name = "entryCount";
            this.entryCount.ReadOnly = true;
            this.entryCount.Width = 85;
            // 
            // AllAboutUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 626);
            this.Controls.Add(this.entrancesDataGrid);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.birthdayTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cardsGridView);
            this.Controls.Add(this.paymentsGridView);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.phoneLlabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.garageComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AllAboutUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вся информация";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AllAboutUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrancesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox garageComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label phoneLlabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.DataGridView paymentsGridView;
        private System.Windows.Forms.DataGridView cardsGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView entrancesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryCount;
    }
}