﻿namespace Car
{
    partial class GatesOpenStatistic
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.entrancesDataGrid = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.entrancesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // garageComboBox
            // 
            this.garageComboBox.FormattingEnabled = true;
            this.garageComboBox.Location = new System.Drawing.Point(128, 53);
            this.garageComboBox.Name = "garageComboBox";
            this.garageComboBox.Size = new System.Drawing.Size(121, 24);
            this.garageComboBox.TabIndex = 0;
            this.garageComboBox.SelectedIndexChanged += new System.EventHandler(this.garageComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Гараж";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(128, 105);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 17);
            this.nameLabel.TabIndex = 4;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(128, 150);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(0, 17);
            this.surnameLabel.TabIndex = 5;
            // 
            // entrancesDataGrid
            // 
            this.entrancesDataGrid.AllowUserToAddRows = false;
            this.entrancesDataGrid.AllowUserToDeleteRows = false;
            this.entrancesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.entrancesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.entryCount});
            this.entrancesDataGrid.Location = new System.Drawing.Point(41, 204);
            this.entrancesDataGrid.Name = "entrancesDataGrid";
            this.entrancesDataGrid.ReadOnly = true;
            this.entrancesDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.entrancesDataGrid.RowTemplate.Height = 24;
            this.entrancesDataGrid.Size = new System.Drawing.Size(327, 253);
            this.entrancesDataGrid.TabIndex = 6;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // entryCount
            // 
            this.entryCount.HeaderText = "Заездов";
            this.entryCount.Name = "entryCount";
            this.entryCount.ReadOnly = true;
            // 
            // GatesOpenStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 469);
            this.Controls.Add(this.entrancesDataGrid);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.garageComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GatesOpenStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GatesOpenStatistic";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GatesOpenStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entrancesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox garageComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.DataGridView entrancesDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryCount;
    }
}