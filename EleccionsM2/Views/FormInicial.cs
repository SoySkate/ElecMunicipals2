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
            mostrarMunicipis();
            dataGridViewMunicipis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMunicipis.SelectionChanged += DataGridView1_SelectionChanged;
            progresbuttons();
        }

        EleccionsViewModel viewModel = new EleccionsViewModel();

        public void progresbuttons()
        {
            if (dataGridViewMunicipis.Rows.Count == 0)
            {
                buttonAddCandidat.Visible = false;
                buttonAddPartit.Visible = false;
                buttonAddTaula.Visible = false;
            }
            else
            {
                buttonAddPartit.Visible = true;
                buttonAddTaula.Visible = true;
                if (dataGridViewPartits.Rows.Count == 0)
                {
                    buttonAddCandidat.Visible = true;
                }
            }
        }
        public void mostrarMunicipis()
        {
            if (viewModel.ListaMunicipis.Count == 0)
            {
                dataGridViewMunicipis.DataSource = null;
                dataGridViewMunicipis.Rows.Clear();
                dataGridViewMunicipis.Columns.Clear();
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBoxNomTaula.ReadOnly = true;
                textBoxCensTaula.ReadOnly = true;
                textBoxNomPartit.ReadOnly = true;
                textBoxNomCandidat.ReadOnly = true;
            }
            else { dataGridViewMunicipis.DataSource = viewModel.ListaMunicipis;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
            }
            //dataGridViewMunicipis.Refresh();
            //dataGridViewMunicipis.DataMember = "ListaMunicipis";
        }
        public void mostrarPartitsAndTaules(long idMuni)
        {
            if (idMuni > 0)
            {
                viewModel.idSelectedMostrarPartidosAndTaules(idMuni);
                if (viewModel.ListaMunicipis.Count == 0)
                {
                    textBoxNomPartit.ReadOnly = true;
                    textBoxNomCandidat.ReadOnly = true;
                    dataGridViewCandidats.DataSource = null;
                    dataGridViewPartits.DataSource = null;
                    dataGridViewTaules.DataSource = null;
                    textBoxNomTaula.ReadOnly = true;
                    textBoxCensTaula.ReadOnly = true;                   
                }
                else
                {
                    if (viewModel.ActualMunicipi.llistaPartits.Count > 0 && viewModel.ActualMunicipi != null)
                    {
                        dataGridViewPartits.DataSource = viewModel.ListaPartitsMunicipi;
                        textBoxNomPartit.ReadOnly = false;
                        textBoxNomCandidat.ReadOnly = false;
                        if (viewModel.ActualPartit.candidats.Count == 0)
                        {
                            textBoxNomCandidat.ReadOnly = true;
                            dataGridViewCandidats.DataSource = null;
                        }
                    }
                    else
                    {
                        textBoxNomPartit.ReadOnly = true;
                        textBoxNomCandidat.ReadOnly = true;
                        dataGridViewCandidats.DataSource = null;
                        dataGridViewPartits.DataSource = null;                        

                    }
                    if (viewModel.ActualMunicipi.taulesElectorals.Count > 0)
                    {
                        dataGridViewTaules.DataSource = viewModel.ListaTaulesMunicipi;
                        dataGridViewTaules.Columns[3].Visible = false;
                        textBoxNomTaula.ReadOnly = false;
                        textBoxCensTaula.ReadOnly = false;
                    }
                    else
                    {
                        textBoxNomTaula.ReadOnly = true;
                        textBoxCensTaula.ReadOnly = true;
                        dataGridViewTaules.DataSource = null;
                    }
                }
            }
        }
        public void mostrarCandidats(long idPartit)
        {
            if (idPartit > 0)
            {
                viewModel.idSelectedPartidoMostrarCandidatos(idPartit);
                if (viewModel.ActualPartit.candidats.Count > 0)
                {
                    dataGridViewCandidats.DataSource = viewModel.ListaCandidats;
                }
                else
                {
                    dataGridViewCandidats.DataSource = null;
                }
            }
        }
        //Buttons load and save changes
        //refreshDOne
        public void dataRefresh()
        {
            dataGridViewMunicipis.DataBindings.Clear();
            dataGridViewMunicipis.DataSource = null;
            dataGridViewMunicipis.Rows.Clear();
            dataGridViewMunicipis.Columns.Clear();
            dataGridViewCandidats.DataSource = null;
            dataGridViewPartits.DataSource = null;
            dataGridViewTaules.DataSource = null;
            mostrarMunicipis();
            viewModel.Grabar();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataRefresh();
        }
        //Funcio per trobar el ID de la rowSelected
        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            long idMuni = 0;
            if (dataGridViewMunicipis.SelectedRows.Count > 0)
            {
                DataGridViewRow a;
                a = dataGridViewMunicipis.SelectedRows[0];
                foreach (DataGridViewColumn col in dataGridViewMunicipis.Columns)
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
            if (dataGridViewPartits.SelectedRows.Count > 0)
            {
                DataGridViewRow a;
                a = dataGridViewPartits.SelectedRows[0];
                foreach (DataGridViewColumn col in dataGridViewPartits.Columns)
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
            if (dataGridViewCandidats.SelectedRows.Count > 0)
            {
                DataGridViewRow a;
                a = dataGridViewCandidats.SelectedRows[0];
                foreach (DataGridViewColumn col in dataGridViewCandidats.Columns)
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
            if (dataGridViewTaules.SelectedRows.Count > 0)
            {
                DataGridViewRow a;
                a = dataGridViewTaules.SelectedRows[0];
                foreach (DataGridViewColumn col in dataGridViewTaules.Columns)
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
            FormMunicipi formMunicipi = new();
            if (formMunicipi.ShowDialog() == DialogResult.OK)
            {//crido una funcio per enviarho directament al context i també ho poso a viewmodel (una mica raro)
                viewModel.addmunicipio(formMunicipi.Municipi);
                dataRefresh();
                progresbuttons();
                viewModel.Grabar();
            }
            else { MessageBox.Show("Cancelado"); }
        }
        private void buttonAddPartit_Click(object sender, EventArgs e)
        {
            FormPartit formPartit = new FormPartit();
            if (formPartit.ShowDialog() == DialogResult.OK)
            {
                viewModel.addPartit(formPartit.PartitMunicipi);
                dataRefresh();
                progresbuttons();
                viewModel.Grabar();
            }
            else { MessageBox.Show("Cancelado"); }
        }
        private void buttonAddCandidat_Click(object sender, EventArgs e)
        {
            FormCandidat formCandidat = new FormCandidat();
            if (formCandidat.ShowDialog() == DialogResult.OK)
            {
                viewModel.addCandidat(formCandidat.Candidat, textBox2.Text);
                dataRefresh();
                viewModel.Grabar();
            }
            else { MessageBox.Show("Cancelado"); }
        }
        //button addTaula:
        private void button3_Click(object sender, EventArgs e)
        {
            FormTaula formTaula = new FormTaula();
            if (formTaula.ShowDialog() == DialogResult.OK)
            {
                viewModel.addTaula(formTaula.TaulaElectoral);
                dataRefresh();
                viewModel.Grabar();
            }
            else { MessageBox.Show("Cancelado"); }
        }
        //deletebuttons:
        private void buttonDeleteMuni_Click(object sender, EventArgs e)
        {
            viewModel.eliminarMunicipi();
            dataRefresh();
        }
        private void buttonDeletePartit_Click(object sender, EventArgs e)
        {
            viewModel.eliminarPartit();
            dataRefresh();
        }
        private void buttonDeleteCandidat_Click(object sender, EventArgs e)
        {
            viewModel.eliminarCandidat();
            dataRefresh();
        }
        private void buttonDeleteTaula_Click(object sender, EventArgs e)
        {
            viewModel.eliminarTaula();
            dataRefresh();
        }
        //Capar el maximo de caracteres de los textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 20;
        }
        private void textBoxNomPartit_TextChanged(object sender, EventArgs e)
        {
            textBoxNomPartit.MaxLength = 20;
        }
        private void textBoxNomCandidat_TextChanged(object sender, EventArgs e)
        {
            textBoxNomCandidat.MaxLength = 30;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 2;
        }
        private void textBoxNomTaula_TextChanged(object sender, EventArgs e)
        {
            textBoxNomTaula.MaxLength = 15;
        }
        private void textBoxCensTaula_TextChanged(object sender, EventArgs e)
        {
            textBoxCensTaula.MaxLength = 5;
        }

        private void FormInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            viewModel.Grabar();
        }

    }
}
