using EleccionsM2.Models;
using EleccionsM2.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
                textBoxNomPartit.ReadOnly = false;
            }
            //este condicional chequea si hay data en partidos y si no hay deja las datagrid partit i candidat vacias
            try
            {
                if (viewModel.ActualMunicipi.llistaPartits.Count == 0)
                {
                    textBoxNomPartit.ReadOnly = true;
                    dataGridView3.DataSource = null;
                    dataGridView2.DataSource = null;
                    viewModel.VaciarListaCandidatos();
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
        //Buttons load and save changes
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarMunicipis();
        }
        private void btnGuardarDades_Click(object sender, EventArgs e)
        {
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
                bindtextBoxMunicipi();

            }
        }
        private void dataGridView2_SelectionChanged(object? sender, EventArgs e)
        {
            long idPartit = 0;
            if (dataGridView2.SelectedRows.Count > 0)
            {
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
                bindtextBoxPartit();
            }
        }
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            long idCandidat = 0;
            if (dataGridView3.SelectedRows.Count > 0)
            {
                DataGridViewRow a;
                a = dataGridView3.SelectedRows[0];
                foreach (DataGridViewColumn col in dataGridView3.Columns)
                {
                    if (col.DataPropertyName == "ID")
                    {
                        idCandidat = (long)a.Cells[col.Index].Value;
                    }
                }
                viewModel.idSelectedCandidat(idCandidat);
                bindtextBoxCandidat();
            }
        }
        //Recoge el actual municipi i lo bindea con el textbox1
        public void bindtextBoxMunicipi()
        {
            var municipi = viewModel.passarMuncipiTxt();
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", municipi, "nomMunicipi");
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", municipi, "numeroRegidors");
        }
        public void bindtextBoxPartit()
        {
            var partit = viewModel.passarPartitTxt();
            textBoxNomPartit.DataBindings.Clear();
            textBoxNomPartit.DataBindings.Add("Text", partit, "nomPartit");
        }
        //no funca esta funcionla del textboxCandidat
        public void bindtextBoxCandidat()
        {
            var candidat = viewModel.passarCandidatTxt();
            textBoxNomCandidat.DataBindings.Clear();
            textBoxNomCandidat.DataBindings.Add("Text", candidat, "nomCandidat");
        }

    }
}
