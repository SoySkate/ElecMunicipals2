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
using EleccionsM2.Views;

namespace ResultadosEleccionesM.ViewsResultats
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonConfiguracio_Click(object sender, EventArgs e)
        {
            FormInicial formInicial = new FormInicial();
            formInicial.ShowDialog();
        }
        private void buttonAfegirResultats_Click(object sender, EventArgs e)
        {
            //No funca loko xd
            FormResultados formresultats = new FormResultados();
            formresultats.ShowDialog();
        }
        private void buttonDiaEleccions_Click(object sender, EventArgs e)
        {
            FormDiaEleccions formDiaEleccions = new FormDiaEleccions();
            formDiaEleccions.ShowDialog();
        }
    }
}
