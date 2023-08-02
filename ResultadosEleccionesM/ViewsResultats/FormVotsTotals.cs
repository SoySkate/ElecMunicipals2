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

namespace ResultadosEleccionesM.ViewsResultats
{
    public partial class FormVotsTotals : Form
    {
        VotsTotalsViewModel viewModelVotsTotal = new();
        public ResultatsTaula ResultatTaula { get => viewModelVotsTotal.VotsTotalsResultatForm; }
        public FormVotsTotals()
        {
            InitializeComponent();
            textBoxVotsTotals.DataBindings.Clear();
            textBoxVotsTotals.DataBindings.Add("Text", viewModelVotsTotal.VotsTotalsResultatForm.votsTotals, "votsTotals");
        }

        private void textBoxVotsTotals_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab) && int.Parse(textBoxVotsTotals.Text) > 0)
            {
                buttonOK.Focus();
            }
        }

        private void textBoxVotsTotals_TextChanged(object sender, EventArgs e)
        {
            textBoxVotsTotals.MaxLength = 7;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
