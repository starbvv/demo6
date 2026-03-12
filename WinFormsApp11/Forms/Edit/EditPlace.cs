using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp11.Models;
using WinFormsApp11.Service.ForDB;

namespace WinFormsApp11.Forms.Edit
{
    public partial class EditPlace : Form
    {
        private readonly Place curPlace;
        public EditPlace(Place place)
        {
            InitializeComponent();
            curPlace = place;
        }
        private bool CheckValue()
        {
            if (Convert.ToInt32(numberBox) == 0 || numberBox.Text == string.Empty)
            {
                MessageBox.Show("Проверьте номер");
                return false;
            }
            if (Convert.ToInt32(etazhNumberic) == 0)
            {
                MessageBox.Show("Этаж не может быть 0 или ниже");
                return false;
            }
            if (CategoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Проверьте категорию");
                return false;
            }
            return true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(CheckValue())
            {
                EditDB.EditPlace(curPlace.Id, Convert.ToInt32(numberBox), Convert.ToInt32(etazhNumberic), CategoryComboBox.Text, DescBox.Text);
            }
            this.Close();
        }
    }
}
