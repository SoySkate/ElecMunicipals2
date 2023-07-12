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

        }
        EleccionsViewModel viewModel = new EleccionsViewModel();

        public void mostrarMunicipis()
        {
            dataGridView1.DataSource = viewModel;
            dataGridView1.DataMember = "ListaMunicipis";

        }
        public void mostrarPartits()
        {
            dataGridView2.DataSource = viewModel;
            //filtrar?
            


            dataGridView2.DataMember = "ListaPartits";
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

        //aqui controlo la cell especifica pq es un button y hacerle cosassasasas
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col; int row;
            col = e.ColumnIndex;
            row = e.RowIndex;
            if (col == 3 && row == 0)
            {
                mostrarPartits();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col; int row;
            col = e.ColumnIndex;
            row = e.RowIndex;
            if (col == 2 && row == 0)
            {
                mostrarCandidats();
            }
        }
    }
}
