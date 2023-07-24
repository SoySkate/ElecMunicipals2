using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EleccionsM2.Models;
using EleccionsM2.ViewModel;
using Microsoft.Identity.Client;

namespace EleccionsM2.Views
{
    public partial class FormResultatsT : Form
    {
        ResultatTViewModel viewModelResultatT = new ResultatTViewModel();
        VotsPerLlistaViewModel viewModelVotsPerLlista = new VotsPerLlistaViewModel();
        public ResultatsTaula ResultatsTaula { get => viewModelResultatT.ResultatTForm;}
        public VotsPerLlista ActualVot { get; set; } = new();
        public FormResultatsT()
        {
            InitializeComponent();
            textBoxVotsBlanc.DataBindings.Clear();
            textBoxVotsBlanc.DataBindings.Add("Text", viewModelResultatT.ResultatTForm, "votsBlanc");
            textBoxVotsNulls.DataBindings.Clear();
            textBoxVotsNulls.DataBindings.Add("Text", viewModelResultatT.ResultatTForm, "votsNul");
            //A ver solucionar esto:
            textBoxVotsPartit.DataBindings.Clear();
            textBoxVotsPartit.DataBindings.Add("Text", viewModelVotsPerLlista.VotsPerLlistaForm, "numeroVotsLlista");
            dataGridViewVotsPartit.DataSource = null;           
            dataGridViewVotsPartit.DataSource = viewModelResultatT.ResultatTForm.votsLlista;
        }
        private void buttonAddResultatTaula_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void buttonAddVotPartit_Click(object sender, EventArgs e)
        {
            VotsPerTaula();
        }
        public void VotsPerTaula()
        {           
            //esto va asi? xd
            if (textBoxVotsPartit.Text != string.Empty)
            {
                //lo minimo de logica que he puesto creo nose si va asi
                viewModelResultatT.addListaVots(viewModelVotsPerLlista.VotsPerLlistaForm);
            }
        }
        private void textBoxVotsBlanc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxVotsNulls_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxVotsPartit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
