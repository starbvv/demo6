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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp11.Forms.Add
{
    public partial class AddCheckArenda : Form
    {
        public AddCheckArenda()
        {
            InitializeComponent();
            ArendaComboBox.Items.AddRange(GetDB.GetPlaces().ToArray());
        }
        private bool CheckValue()
        {
            if(ArendaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Проверьте номер");
                return false;
            }
            if (StatusComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Проверьте статус");
                return false;
            }
            return true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(CheckValue())
            {
                var placeId = ArendaComboBox.SelectedItem as Place;
                AddDB.AddEnd(placeId, dateTimeValue.Value.Date, StatusComboBox.Text);
            }
            this.Close();
        }
    }
}
