
using WinFormsApp11.Models;
using WinFormsApp11.Service.ForDB;

namespace WinFormsApp11.Forms.Edit
{
    public partial class EditPple : Form
    {
        private readonly Pple curPple;
        public EditPple(Pple pple)
        {
            InitializeComponent();
            curPple = pple;
        }
        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
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
            if (nameBox.Text == string.Empty)
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
                EditDB.EditPple(curPple.Id, SurnameBox.Text, nameBox.Text, LastnameBox.Text);
            }
            this.Close();
        }
    }
}
