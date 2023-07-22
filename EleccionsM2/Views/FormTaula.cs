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
using EleccionsM2.ViewModel;

namespace EleccionsM2.Views
{
    public partial class FormTaula : Form
    {
        TaulaViewModel viewModelTaula = new TaulaViewModel();
        public TaulaElectoral TaulaElectoral { get => viewModelTaula.TaulaForm; private set => viewModelTaula.TaulaForm = value; }
        public FormTaula()
        {
            InitializeComponent();
            textBoxNomTaula.DataBindings.Clear();
            textBoxNomTaula.DataBindings.Add("Text", viewModelTaula.TaulaForm, "nomTaula");
            textBoxCensTaula.DataBindings.Clear();
            textBoxCensTaula.DataBindings.Add("Text", viewModelTaula.TaulaForm, "censTaula");
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonCrearTaula_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxCensTaula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab) && textBoxNomTaula.Text != string.Empty && int.Parse(textBoxCensTaula.Text) > 0)
            {
                buttonCrearTaula.Focus();
            }
        }

        private void textBoxNomTaula_TextChanged(object sender, EventArgs e)
        {
            textBoxNomTaula.MaxLength = 15;
        }

        private void textBoxCensTaula_TextChanged(object sender, EventArgs e)
        {
            textBoxCensTaula.MaxLength = 5;
        }

        private void textBoxNomTaula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                textBoxCensTaula.Focus();
            }
        }
    }
}
