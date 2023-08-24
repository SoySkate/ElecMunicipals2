using System;
using EleccionsM2;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EleccionsM2.ViewModel;
using EleccionsM2.Models;

namespace ResultadosEleccionesM.ViewsResultats
{
    public partial class FormDiaEleccions : Form
    {
        DiaEleccionesViewModel viewModel = new DiaEleccionesViewModel();
        public FormDiaEleccions()
        {
            InitializeComponent();
            comboBoxMunicipisDiaE.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMunicipisDiaE.Enabled = true;
            comboBoxMunicipisDiaE.DataSource = viewModel.ListaMunicipis;
            comboBoxTaules.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTaules.Enabled = true;
            comboBoxTaules.DataSource = viewModel.ListaTaulesMunicipi;
            this.AutoScroll = true;
            
        }
        public void clean()
        {
            textBoxNumRegidors.Text = string.Empty;
            textBoxParticipacio.Text = string.Empty;
            dataGridViewEscons.DataSource = null;
            dataGridViewRegidors.DataSource = null;
            dataGridViewTaula1.DataSource = null;
            dataGridViewTaula3.DataSource = null;
            textBoxVBlan.Text = string.Empty;
            textBoxVotsEscrotats.Text = string.Empty;
            textBoxVotsNuls.Text = string.Empty;
            textBoxPercentEscrotat.Text = string.Empty;
            textBoxParticipacioTaula.Text = string.Empty;
            textBoxVotsTotals.Text = string.Empty;
        }
        private void comboBoxMunicipisDiaE_SelectedIndexChanged(object sender, EventArgs e)
        {
            var muni = (Municipi)comboBoxMunicipisDiaE.SelectedItem;
            viewModel.selectedMunicipi(muni);

            if(viewModel.ListaPartitsMunicipi.Count>0 && viewModel.ListaTaulesMunicipi.Count>0) {
            textBoxNumRegidors.DataBindings.Clear();
            textBoxNumRegidors.Text = viewModel.ActualMunicipi.numeroRegidors.ToString();
            viewModel.calcularDades();
            textBoxParticipacio.Text = viewModel.Participacio.ToString() + " %";
            viewModel.visualitzarEscons();
            viewModel.AsignarEscons();
            viewModel.seleccionarCandidats();
            dataGridViewRegidors.DataSource = null;
            dataGridViewRegidors.DataSource = viewModel.ListaRegidors;
            dataGridViewRegidors.Columns[0].Visible = false;
            dataGridViewEscons.Refresh();
                dataGridViewEscons.DataSource = null;
                dataGridViewEscons.DataSource = viewModel.ListaEsconsPartit;
                dataGridViewEscons.Columns[0].Visible = false;
                //dataGridViewRegidors.Refresh();
                dataGridViewTaula1.DataSource = null;
            dataGridViewTaula1.DataSource = viewModel.ListaTaulesMunicipi;
            dataGridViewTaula1.Columns[0].Visible = false;
            dataGridViewTaula1.Columns[3].Visible = false;

            }
            else
            {
                clean();
            }

        }

        private void comboBoxTaules_SelectedIndexChanged(object sender, EventArgs e)
        {
            var taula = (TaulaElectoral)comboBoxTaules.SelectedItem;
            viewModel.selectedTaula(taula);
            viewModel.dadesTaula();
            dataGridViewTaula3.DataSource = null;
            dataGridViewTaula3.DataSource = viewModel.ActualTaula.resultatsTaula.votsLlista;
            dataGridViewTaula3.Columns[0].Visible = false;
            textBoxVBlan.DataBindings.Clear();
            textBoxVBlan.Text = viewModel.ActualDadesTaula.VotsBlancs.ToString();
            textBoxVotsEscrotats.DataBindings.Clear();
            textBoxVotsEscrotats.Text = viewModel.ActualDadesTaula.VotsEscrotats.ToString();
            textBoxVotsNuls.DataBindings.Clear();
            textBoxVotsNuls.Text = viewModel.ActualDadesTaula.VotsNuls.ToString();
            textBoxPercentEscrotat.DataBindings.Clear();
            textBoxPercentEscrotat.Text = viewModel.ActualDadesTaula.Escrotat.ToString() + " %";
            textBoxParticipacioTaula.DataBindings.Clear();
            textBoxParticipacioTaula.Text = viewModel.ActualDadesTaula.Participació.ToString() + " %";
            textBoxVotsTotals.DataBindings.Clear();
            textBoxVotsTotals.Text = viewModel.ActualDadesTaula.VotsTotals.ToString();           
        }
    }
}