using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp11.Service.ForDB;

namespace WinFormsApp11.Forms.Add
{
    public partial class AddPlace : Form
    {
        public AddPlace()
        {
            InitializeComponent();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != '.' && ch != ',' && ch != '/'&& ch != ' ')
            {
                e.Handled = true;
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyChar == '\x01' || e.KeyChar == '\x03' || e.KeyChar == '\x16' || e.KeyChar == '\x18') return;
        }
        private bool CheckValue()
        {
            if(Convert.ToInt32(numberBox) == 0 || numberBox.Text == string.Empty)
            {
                MessageBox.Show("Проверьте номер");
                return false;
            }
            if(Convert.ToInt32(etazhNumberic) == 0)
            {
                MessageBox.Show("Этаж не может быть 0 или ниже");
                return false;
            }
            if(CategoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Проверьте категорию");
                return false;
            }
            return true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckValue())
            {
                AddDB.AddPlace(Convert.ToInt32(numberBox), Convert.ToInt32(etazhNumberic), CategoryComboBox.Text, DescBox.Text);
            }
            this.Close();
        }
    }
}
