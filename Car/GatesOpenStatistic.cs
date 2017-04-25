using Car.Model;
using Car.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class GatesOpenStatistic : Form
    {
        public GatesOpenStatistic()
        {
            InitializeComponent();
        }

        private void GatesOpenStatistic_Load(object sender, EventArgs e)
        {
            var garages = BussinesLogic.Show.GarageNumbers();            
            garageComboBox.Items.AddRange(garages);
            //garageComboBox.SelectedItem = garages.Last();
        }

        private void garageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = AllUserData.GetSelectedUser(garageComboBox.SelectedItem.ToString());
            nameLabel.Text = user.Name;
            surnameLabel.Text = user.Surname;

            var dates = user.Entrances
                .Select(en => en.EntranceDate)
                .GroupBy(dt => dt)
                .ToList()
                ;

            entrancesDataGrid.Rows.Clear();
            int i = 0;
            foreach (var entrance in dates)
            {
                entrancesDataGrid.Rows.Add();
                entrancesDataGrid.Rows[i].Cells[0].Value = entrance.Key.Date.ToShortDateString();
                entrancesDataGrid.Rows[i].Cells[1].Value = entrance.Count();
                i++;
            }
        }
    }
}
