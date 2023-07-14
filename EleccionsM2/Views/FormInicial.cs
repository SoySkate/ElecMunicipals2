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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EleccionsM2.Views
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

        }

        EleccionsViewModel viewModel = new EleccionsViewModel();

        public void mostrarMunicipis()
        {
            dataGridView1.DataSource = viewModel;
            dataGridView1.DataMember = "ListaMunicipis";
        }
        public void mostrarPartits(long idMuni)
        {

            if (idMuni > 0)
            {
                viewModel.idSelectedMostrarPartidos(idMuni);
                dataGridView2.DataSource = viewModel.ListaPartitsMunicipi;
            }
            //este condicional chequea si hay data en partidos y si no hay deja las datagrid partit i candidat vacias
            try
            {
                if (viewModel.ActualMunicipi.llistaPartits.Count == 0)
                {
                    dataGridView3.DataSource = null;
                    viewModel.VaciarListaCandidatos();
                    //dataGridView3.DataSource = viewModel.ListaCandidats;
                }
            }
            catch (Exception) { MessageBox.Show("No hay nada I con esto me peta igual porque?"); }
        }
        public void mostrarCandidats(long idPartit)
        {
            if (idPartit > 0)
            {
                if (viewModel.ListaPartitsMunicipi.Count > 0)
                {
                    viewModel.idSelectedPartidoMostrarCandidatos(idPartit);
                    dataGridView3.DataSource = viewModel.ListaCandidats;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarMunicipis();
            viewModel.Grabar();
        }
        //Funcio per trobar el ID de la rowSelected
        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            long idMuni = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow a;
                a = dataGridView1.SelectedRows[0];
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col.DataPropertyName == "ID")
                    {
                        idMuni = (long)a.Cells[col.Index].Value;
                    }
                }
                mostrarPartits(idMuni);
            }
        }
        private void dataGridView2_SelectionChanged(object? sender, EventArgs e)
        {
            long idPartit = 0;
            if (dataGridView2.SelectedRows.Count > 0)
            {
                //A ver el evento este no funca rmano
                DataGridViewRow a;
                a = dataGridView2.SelectedRows[0];
                foreach (DataGridViewColumn col in dataGridView2.Columns)
                {
                    if (col.DataPropertyName == "ID")
                    {
                        idPartit = (long)a.Cells[col.Index].Value;
                    }
                }
                mostrarCandidats(idPartit);
            }
        }
        private void btnGuardarDades_Click(object sender, EventArgs e)
        {
            viewModel.Grabar();
        }
    }
}
