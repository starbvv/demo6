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
    public partial class AddPple : Form
    {
        public AddPple()
        {
            InitializeComponent();
        }
        private void nameBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyChar == '\x01' || e.KeyChar == '\x03' || e.KeyChar == '\x16' || e.KeyChar == '\x18') return;
        }
        private bool CheckValue()
        {
            if(nameBox.Text == string.Empty)
            {
                MessageBox.Show("Проверьте имя");
                return false;
            }
            if (SurnameBox.Text == string.Empty)
            {
                MessageBox.Show("Проверьте Фамилию");
                return false;
            }
            return true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(CheckValue())
            {
                AddDB.AddPple(SurnameBox.Text, nameBox.Text, LastnameBox.Text);
            }
            this.Close();
        }
    }
}
