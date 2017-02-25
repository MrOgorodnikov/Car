using System;
using System.Windows.Forms;

namespace Car
{
    public partial class ShowAllWriteOffForm : Form
    {
        public ShowAllWriteOffForm()
        {
            InitializeComponent();
        }

        private void ShowAllWriteOffForm_Load(object sender, EventArgs e)
        {
            var allWriteOff = BussinesLogic.Show.GetAllWriteOff();
            int i = 0;
            foreach (var writeOff in allWriteOff)
            {
                writeOffGridView.Rows.Add();
                writeOffGridView.Rows[i].Cells[0].Value = writeOff.DateTime;
                writeOffGridView.Rows[i].Cells[1].Value = writeOff.Sum;                
                i++;
            }
            
        }
    }
}
