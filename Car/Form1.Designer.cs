﻿using System.Drawing;

namespace Car
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.GarageLabel = new System.Windows.Forms.Label();
            this.carLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.FocusTimer = new System.Windows.Forms.Timer(this.components);
            this.openButton = new System.Windows.Forms.Button();
            this.DeleteTimer = new System.Windows.Forms.Timer(this.components);
            this.rebootButton = new System.Windows.Forms.Button();
            this.ballanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(253, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 38);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(253, 95);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(160, 38);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Фамилия";
            // 
            // GarageLabel
            // 
            this.GarageLabel.AutoSize = true;
            this.GarageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GarageLabel.Location = new System.Drawing.Point(253, 127);
            this.GarageLabel.Name = "GarageLabel";
            this.GarageLabel.Size = new System.Drawing.Size(236, 38);
            this.GarageLabel.TabIndex = 3;
            this.GarageLabel.Text = "Номер гаража";
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carLabel.Location = new System.Drawing.Point(253, 164);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(256, 38);
            this.carLabel.TabIndex = 4;
            this.carLabel.Text = "Номер машины";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(938, 503);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(46, 442);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 91);
            this.errorLabel.TabIndex = 5;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(253, 202);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(155, 38);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Телефон";
            // 
            // FocusTimer
            // 
            this.FocusTimer.Enabled = true;
            this.FocusTimer.Interval = 10000;
            this.FocusTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.Location = new System.Drawing.Point(62, 552);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(590, 303);
            this.openButton.TabIndex = 8;
            this.openButton.Text = "Открыть ворота";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Visible = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            this.openButton.MouseLeave += new System.EventHandler(this.openButton_MouseLeave);
            this.openButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openButton_MouseMove);
            // 
            // DeleteTimer
            // 
            this.DeleteTimer.Enabled = true;
            this.DeleteTimer.Interval = 500;
            this.DeleteTimer.Tick += new System.EventHandler(this.DeleteTimer_Tick);
            // 
            // rebootButton
            // 
            this.rebootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rebootButton.Location = new System.Drawing.Point(1062, 12);
            this.rebootButton.Name = "rebootButton";
            this.rebootButton.Size = new System.Drawing.Size(336, 303);
            this.rebootButton.TabIndex = 9;
            this.rebootButton.Text = "Перезгрузка";
            this.rebootButton.UseVisualStyleBackColor = true;
            this.rebootButton.Click += new System.EventHandler(this.rebootButton_Click);
            this.rebootButton.MouseLeave += new System.EventHandler(this.rebootButton_MouseLeave);
            this.rebootButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rebootButton_MouseMove);
            // 
            // ballanceLabel
            // 
            this.ballanceLabel.AutoSize = true;
            this.ballanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ballanceLabel.Location = new System.Drawing.Point(253, 240);
            this.ballanceLabel.Name = "ballanceLabel";
            this.ballanceLabel.Size = new System.Drawing.Size(148, 38);
            this.ballanceLabel.TabIndex = 10;
            this.ballanceLabel.Text = "Балланс";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 964);
            this.Controls.Add(this.ballanceLabel);
            this.Controls.Add(this.rebootButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.carLabel);
            this.Controls.Add(this.GarageLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Пропуск автомобилей";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label GarageLabel;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Timer FocusTimer;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Timer DeleteTimer;
        private System.Windows.Forms.Button rebootButton;
        private System.Windows.Forms.Label ballanceLabel;
    }
}

