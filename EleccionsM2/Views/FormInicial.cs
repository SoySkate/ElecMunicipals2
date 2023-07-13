using EleccionsM2.Models;
using EleccionsM2.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.DataContracts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EleccionsM2.Views
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.CellClick += dataGridView1_CellClick;

        }
        public long B;
        public int selectedRowMuni;
        public int selectedRowParti;
        EleccionsViewModel viewModel = new EleccionsViewModel();

        public void mostrarMunicipis()
        {
            dataGridView1.DataSource = viewModel;
            dataGridView1.DataMember = "ListaMunicipis";
        }
        public void mostrarPartits()
        {
            if (B > 0)
            {
                dataGridView2.DataSource = null;
                viewModel.idSelectedMostrarPartidos(B);
                dataGridView2.DataSource = viewModel.ListaPartitsMunicipi;
                //dataGridView2.DataMember = "ListaPartitsMunicipi";
                dataGridView2.Refresh();
            }
        }
        public void mostrarCandidats()
        {
            dataGridView3.DataSource = viewModel;
            dataGridView3.DataMember = "ListaCandidats";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarMunicipis();
            viewModel.Grabar();
        }

        //aqui trobo el id de la row per pasarli a laltre funció
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowMuni = e.RowIndex;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowParti = e.RowIndex;
            int col; int row;
            col = e.ColumnIndex;
            row = e.RowIndex;
            if (col == 2 && row == 0)
            {
                //mostrarCandidats();
            }
        }
        //Funcio per trobar el ID de la rowSelected
        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow a;
                a = dataGridView1.SelectedRows[selectedRowMuni];
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col.DataPropertyName == "ID")
                    {
                        B = (long)a.Cells[col.Index].Value;
                    }
                }
                MessageBox.Show(B.ToString());
                mostrarPartits();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow a;
                a = dataGridView2.SelectedRows[selectedRowParti];
                foreach ()
                {
                    //fer lo mismo que la func de arriba
                }
              
            }
        }
    }
}
