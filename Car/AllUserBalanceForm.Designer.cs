namespace Car
{
    partial class AllUserBalanceForm
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
            this.balanceGridView = new System.Windows.Forms.DataGridView();
            this.garageNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.balanceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // balanceGridView
            // 
            this.balanceGridView.AllowUserToAddRows = false;
            this.balanceGridView.AllowUserToDeleteRows = false;
            this.balanceGridView.AllowUserToResizeRows = false;
            this.balanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.garageNumber,
            this.userName,
            this.userSurname,
            this.userPhone,
            this.userBalance});
            this.balanceGridView.Location = new System.Drawing.Point(12, 12);
            this.balanceGridView.MultiSelect = false;
            this.balanceGridView.Name = "balanceGridView";
            this.balanceGridView.ReadOnly = true;
            this.balanceGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.balanceGridView.RowTemplate.Height = 24;
            this.balanceGridView.Size = new System.Drawing.Size(951, 589);
            this.balanceGridView.TabIndex = 0;
            // 
            // garageNumber
            // 
            this.garageNumber.HeaderText = "Гараж";
            this.garageNumber.Name = "garageNumber";
            this.garageNumber.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.HeaderText = "Имя";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 150;
            // 
            // userSurname
            // 
            this.userSurname.HeaderText = "Фамилия";
            this.userSurname.Name = "userSurname";
            this.userSurname.ReadOnly = true;
            this.userSurname.Width = 150;
            // 
            // userPhone
            // 
            this.userPhone.HeaderText = "Моб. номер";
            this.userPhone.Name = "userPhone";
            this.userPhone.ReadOnly = true;
            this.userPhone.Width = 160;
            // 
            // userBalance
            // 
            this.userBalance.HeaderText = "Балланс";
            this.userBalance.Name = "userBalance";
            this.userBalance.ReadOnly = true;
            this.userBalance.Width = 110;
            // 
            // AllUserBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(972, 613);
            this.Controls.Add(this.balanceGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AllUserBalanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Даные о всех";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AllUserBalanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balanceGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView balanceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn garageNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn userBalance;
    }
}