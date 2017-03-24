namespace Car
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
            this.label1 = new System.Windows.Forms.Label();
            this.opensCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.carsCountLabel = new System.Windows.Forms.Label();
            this.deleteDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Открытий ворот: ";
            // 
            // opensCountLabel
            // 
            this.opensCountLabel.AutoSize = true;
            this.opensCountLabel.Location = new System.Drawing.Point(252, 84);
            this.opensCountLabel.Name = "opensCountLabel";
            this.opensCountLabel.Size = new System.Drawing.Size(46, 17);
            this.opensCountLabel.TabIndex = 1;
            this.opensCountLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "* На один автомобиль необходимо 2 открытия ворот";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(503, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Примерное количесто автомобилей, проехавших по открытию охранника: ";
            // 
            // carsCountLabel
            // 
            this.carsCountLabel.AutoSize = true;
            this.carsCountLabel.Location = new System.Drawing.Point(82, 220);
            this.carsCountLabel.Name = "carsCountLabel";
            this.carsCountLabel.Size = new System.Drawing.Size(46, 17);
            this.carsCountLabel.TabIndex = 4;
            this.carsCountLabel.Text = "label4";
            // 
            // deleteDataButton
            // 
            this.deleteDataButton.Location = new System.Drawing.Point(79, 339);
            this.deleteDataButton.Name = "deleteDataButton";
            this.deleteDataButton.Size = new System.Drawing.Size(169, 63);
            this.deleteDataButton.TabIndex = 5;
            this.deleteDataButton.Text = "Обнулить данные";
            this.deleteDataButton.UseVisualStyleBackColor = true;
            this.deleteDataButton.Click += new System.EventHandler(this.deleteDataButton_Click);
            // 
            // GatesOpenStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 469);
            this.Controls.Add(this.deleteDataButton);
            this.Controls.Add(this.carsCountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opensCountLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GatesOpenStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GatesOpenStatistic";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GatesOpenStatistic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label opensCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label carsCountLabel;
        private System.Windows.Forms.Button deleteDataButton;
    }
}