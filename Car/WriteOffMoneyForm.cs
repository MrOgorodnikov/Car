using Car.BussinesLogic;
using System;
using System.Windows.Forms;

namespace Car
{
    public partial class WriteOffMoneyForm : Form
    {
        public WriteOffMoneyForm()
        {
            InitializeComponent();
            writeOffButton.Enabled = false;
        }

        private void writeOffButton_Click(object sender, EventArgs e)
        {           
            try
            {
                Payment.WriteOff(Convert.ToDouble(writeOffSumTextBox.Text));
                DialogResult result = MessageBox.Show("Успех!", "Успех!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)                
                    Close();                
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButtons.OK);
            }            
            
        }

        private void writeOffSumTextBox_TextChanged(object sender, EventArgs e)
        {
            if (writeOffSumTextBox.Text.Length > 0)            
                writeOffButton.Enabled = true;            
            else            
                writeOffButton.Enabled = false;            
        }
    }
}
