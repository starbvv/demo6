using WinFormsApp11.Models;
using WinFormsApp11.Service.ForDB;

namespace WinFormsApp11.Forms.Edit
{
    public partial class EditArenda : Form
    {
        private readonly ZppleLifePelmeni curArenda;
        public EditArenda(ZppleLifePelmeni arenda)
        {
            InitializeComponent();
            curArenda = arenda;
            comboBox1.Items.AddRange(GetDB.GetPlaces().ToArray());
            comboBox2.Items.AddRange(GetDB.GetPples().ToArray());
        }
        private bool CheckValue()
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Проверьте номер");
                return false;
            }
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Проверьте Человека");
                return false;
            }
            if (dateTimePicker2.Value.Date == dateTimePicker1.Value.Date)
            {
                MessageBox.Show("Дата выезда и дата заселения не может совпадать");
                return false;
            }
            if (dateTimePicker2.Value.Date > dateTimePicker1.Value.Date)
            {
                MessageBox.Show("Дата выезда не может быть меньше даты заезда");
                return false;
            }
            return true;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(CheckValue())
            {
                var ppleId = comboBox1.SelectedItem as Pple;
                var placeId = comboBox2.SelectedItem as Place;
                EditDB.EditArenda(curArenda.Id, placeId.Id, ppleId.Id, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            }
            this.Close();
        }
    }
}
