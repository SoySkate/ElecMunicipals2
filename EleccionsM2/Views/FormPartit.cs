using EleccionsM2.Models;
using EleccionsM2.ViewModel;
using System;
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
    public partial class FormPartit : Form
    {
        PartitViewModel viewModelPartit = new();
        public PartitMunicipi PartitMunicipi { get => viewModelPartit.PartitForm; private set => viewModelPartit.PartitForm = value; }
        public FormPartit()
        {
            InitializeComponent();
            textBoxNomPartit.DataBindings.Clear();
            textBoxNomPartit.DataBindings.Add("Text", viewModelPartit.PartitForm, "nomPartit");
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonCrearPartit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxNomPartit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNomPartit_TextChanged(object sender, EventArgs e)
        {
            textBoxNomPartit.MaxLength = 20;
        }
    }
}
