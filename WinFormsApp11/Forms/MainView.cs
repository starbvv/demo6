using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLitePCL;
using WinFormsApp11.Forms.Add;
using WinFormsApp11.Forms.Edit;
using WinFormsApp11.Models;
using WinFormsApp11.Service.ForDB;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            addP.FormClosing += AddP_FormClosing;
        }

        private void AddP_FormClosing(object? sender, FormClosingEventArgs e)
        {
            dataGridView1.DataSource = GetDB.GetPlaces();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddPple addPp = new AddPple();
            addPp.ShowDialog();
            addPp.FormClosing += AddPp_FormClosing;
        }

        private void AddPp_FormClosing(object? sender, FormClosingEventArgs e)
        {
            dataGridView1.DataSource = GetDB.GetPples();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddArenda addA = new AddArenda();
            addA.ShowDialog();
            addA.FormClosing += AddA_FormClosing;
        }

        private void AddA_FormClosing(object? sender, FormClosingEventArgs e)
        {
            dataGridView1.DataSource = GetDB.GetArenda();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDB.GetEnd();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddCheckArenda addA = new AddCheckArenda();
            addA.ShowDialog();
            addA.FormClosing += AddAA_FormClosing;
        }

        private void AddAA_FormClosing(object? sender, FormClosingEventArgs e)
        {
            dataGridView1.DataSource = GetDB.GetEnd();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndx = dataGridView1.SelectedCells[0].RowIndex;
            var row = dataGridView1.Rows[rowIndx];
            var data = row.DataBoundItem;

            if (data is Pple curPple)
            {
                using var form = new EditPple(curPple);
                form.ShowDialog();
                dataGridView1.DataSource = GetDB.GetPples();
            }
            else if (data is ZppleLifePelmeni curArenda)
            {
                using var form = new EditArenda(curArenda);
                form.ShowDialog();
                dataGridView1.DataSource = GetDB.GetArenda();
            }
        }
        private void Delete(DataGridView dataGrid)
        {
            int rowIndx = dataGrid.SelectedCells[0].RowIndex;
            var row = dataGrid.Rows[rowIndx];
            var data = row.DataBoundItem;
            if (data is Pple curPple)
            {
                DeleteDB.RemovePple(curPple.Id);
                dataGridView1.DataSource = GetDB.GetPples();
            }
            else if (data is ZppleLifePelmeni curArenda)
            {
                DeleteDB.RemoveArenda(curArenda.Id);
                dataGridView1.DataSource = GetDB.GetArenda();
            }
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    Delete(sender as DataGridView);
                    break;
            }
        }
    }
}
