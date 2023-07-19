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
        public void mostrarPartitsAndTaules(long idMuni)
        {
            if (idMuni > 0)
            {
                viewModel.idSelectedMostrarPartidosAndTaules(idMuni);
                dataGridView2.DataSource = viewModel.ListaPartitsMunicipi;
                dataGridView4.DataSource = viewModel.ListaTaulesMunicipi;
                dataGridView4.Columns[3].Visible = false;
                textBoxNomPartit.ReadOnly = false;
                textBoxNomCandidat.ReadOnly = false;
                textBoxNomTaula.ReadOnly = false;
                textBoxCensTaula.ReadOnly = false;
            }
            //este condicional chequea si hay data en partidos y si no hay deja las datagrid partit i candidat vacias
            try
            {
                if (viewModel.ActualMunicipi.llistaPartits.Count == 0)
                {
                    textBoxNomPartit.ReadOnly = true;
                    textBoxNomCandidat.ReadOnly = true;
                    dataGridView3.DataSource = null;
                    dataGridView2.DataSource = null;
                    viewModel.VaciarListaCandidatos();
                }
                if (viewModel.ActualMunicipi.taulesElectorals.Count == 0)
                {
                    textBoxNomTaula.ReadOnly = true;
                    textBoxCensTaula.ReadOnly = true;
                }
            }
            catch (Exception) { MessageBox.Show("Exception rara"); }
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
                mostrarPartitsAndTaules(idMuni);
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
        //esto no funciona nose pq
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
        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            long idTaula = 0;
            if (dataGridView4.SelectedRows.Count > 0)
            {
                DataGridViewRow a;
                a = dataGridView4.SelectedRows[0];
                foreach (DataGridViewColumn col in dataGridView4.Columns)
                {
                    if (col.DataPropertyName == "ID")
                    {
                        idTaula = (long)a.Cells[col.Index].Value;
                    }
                }
                viewModel.idSelectedTaula(idTaula);
                bindtextBoxTaula();
            }
        }
        //Recoge el actual municipi i lo bindea con el textbox1 y así con los siguientes
        public void bindtextBoxMunicipi()
        {
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", viewModel.ActualMunicipi, "nomMunicipi");
            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", viewModel.ActualMunicipi, "numeroRegidors");
        }
        public void bindtextBoxPartit()
        {
            textBoxNomPartit.DataBindings.Clear();
            textBoxNomPartit.DataBindings.Add("Text", viewModel.ActualPartit, "nomPartit");
        }
        public void bindtextBoxCandidat()
        {
            textBoxNomCandidat.DataBindings.Clear();
            textBoxNomCandidat.DataBindings.Add("Text", viewModel.ActualCandidat, "nomCandidat");
        }
        public void bindtextBoxTaula()
        {
            textBoxNomTaula.DataBindings.Clear();
            textBoxNomTaula.DataBindings.Add("Text", viewModel.ActualTaula, "nomTaula");
            textBoxCensTaula.DataBindings.Clear();
            textBoxCensTaula.DataBindings.Add("Text", viewModel.ActualTaula, "censTaula");
        }
        //Crea una instancia del formulario y la usa para acceder a los datos entrados en el form
        //y la del viewmodel de ese form en concreto
        private void buttonAddMuni_Click(object sender, EventArgs e)
        {
            MessageBox.Show(viewModel.ListaMunicipis.Count.ToString());
            FormMunicipi formMunicipi = new();
            if (formMunicipi.ShowDialog() == DialogResult.OK)
            {
                viewModel.ActualMunicipi = formMunicipi.Municipi;
                viewModel.ListaMunicipis.Add(viewModel.ActualMunicipi);
                viewModel.Grabar();
                MessageBox.Show(viewModel.ListaMunicipis.Count.ToString());
            }
            else { MessageBox.Show("XDDDMAL"); }
        }
        private void buttonAddPartit_Click(object sender, EventArgs e)
        {
            FormPartit formPartit = new FormPartit();
            formPartit.ShowDialog();
        }
        private void buttonAddCandidat_Click(object sender, EventArgs e)
        {
            FormCandidat formCandidat = new FormCandidat();
            formCandidat.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FormTaula formTaula = new FormTaula();
            formTaula.ShowDialog();
        }
    }
}
