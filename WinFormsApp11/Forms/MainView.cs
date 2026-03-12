using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp11.Forms.Add;
using WinFormsApp11.Service.ForDB;

namespace WinFormsApp11.Forms.Login
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDB.GetPlaces();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDB.GetPples();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDB.GetArenda();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AddPlace addP = new AddPlace();
            addP.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AddPple addPp = new AddPple();
            addPp.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            AddArenda addA = new AddArenda();
            addA.ShowDialog();
        }
    }
}
