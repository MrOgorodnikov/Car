using Car.Model;
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
            using (var db = new CarCheckerContext())
            {
                var opensCount = db.AdminSettings.ToList().FirstOrDefault(s => s.Name == "openCount").Value;
                opensCountLabel.Text = opensCount;
                var carsCount = Convert.ToInt32(opensCount) / 2;
                carsCountLabel.Text = carsCount.ToString();
            }
        }

        private void deleteDataButton_Click(object sender, EventArgs e)
        {
            using (var db = new CarCheckerContext())
            {
                db.AdminSettings.ToList().FirstOrDefault(s => s.Name == "openCount").Value = "0";
                db.SaveChanges();
                opensCountLabel.Text = "0";
                carsCountLabel.Text = "0";
            }
        }
    }
}
