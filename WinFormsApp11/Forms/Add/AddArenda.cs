using WinFormsApp11.Models;
using WinFormsApp11.Service.ForDB;

namespace WinFormsApp11.Forms.Add
{
    public partial class AddArenda : Form
    {
        public AddArenda()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(GetDB.GetPlaces().ToArray());
            comboBox2.Items.AddRange(GetDB.GetPples().ToArray());
        }
        private bool CheckValue()
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Проверьте номер");
                return false;
            }
            if(comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Проверьте Человека");
                return false;
            }
            if(dateTimePicker2.Value.Date == dateTimePicker1.Value.Date)
            {
                MessageBox.Show("Дата выезда и дата заселения не может совпадать");
                return false;
            }
            if(dateTimePicker2.Value.Date > dateTimePicker1.Value.Date)
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
                var placeId = comboBox1.SelectedItem as Place;
                var ppleId = comboBox2.SelectedItem as Pple;
                AddDB.AddArenda(placeId, ppleId, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            }
            this.Close();
        }
    }
}
