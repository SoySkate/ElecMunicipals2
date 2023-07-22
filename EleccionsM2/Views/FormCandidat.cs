using EleccionsM2.ViewModel;
using System;
using EleccionsM2.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EleccionsM2.Views
{
    public partial class FormCandidat : Form
    {
        CandidatViewModel viewModelCandidat = new();
        public Candidat Candidat { get => viewModelCandidat.CandidatForm; private set => viewModelCandidat.CandidatForm = value; }
        public FormCandidat()
        {
            InitializeComponent();
            textBoxNomCandidat.DataBindings.Clear();
            textBoxNomCandidat.DataBindings.Add("Text", viewModelCandidat.CandidatForm, "nomCandidat");
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonCrearCandidat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxNomCandidat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if(textBoxNomCandidat.Text != string.Empty && e.KeyChar==(char)Keys.Enter)
            {
                buttonCrearCandidat.Focus();
            }
        }

        private void textBoxNomCandidat_TextChanged(object sender, EventArgs e)
        {
            textBoxNomCandidat.MaxLength = 30;
        }
    }
}
