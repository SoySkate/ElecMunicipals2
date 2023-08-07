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
            this.AutoScroll = true;
        }

        private void comboBoxMunicipisDiaE_SelectedIndexChanged(object sender, EventArgs e)
        {
            var muni = (Municipi)comboBoxMunicipisDiaE.SelectedItem;
            viewModel.selectedMunicipi(muni);
            textBoxNumRegidors.DataBindings.Clear();
            textBoxNumRegidors.Text = viewModel.ActualMunicipi.numeroRegidors.ToString();
            viewModel.calcularDades();
            //textBoxParticipacio.DataBindings.Clear();
            //textBoxParticipacio.DataBindings.Add("Text", viewModel,"Participacio");
            textBoxParticipacio.Text = viewModel.Participacio.ToString() + " %";
        }
    }
}