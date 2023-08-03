using EleccionsM2.Models;
using EleccionsM2.ViewModel;
using EleccionsM2;
using ResultadosEleccionesM.ViewsResultats;


namespace ResultadosEleccionesM
{
    public partial class FormResultados : Form
    {
        public FormResultados()
        {
            InitializeComponent();

            comboBoxMunicipis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMunicipis.Enabled = true;
            comboBoxTaules.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTaules.Enabled = true;
            comboBoxMunicipis.DataSource = viewmodelR.ListaMunicipis;
            controlPanel();
            dataGridViewVotsPartit.DataSource = null;
            dataGridViewVotsPartit.DataSource = viewmodelR.ListaVisualVotsPerPartit;

        }
        ResultatsViewModel viewmodelR = new ResultatsViewModel();
        public void controlPanel()
        {
            if (viewmodelR.ListaMunicipis.Count > 0)
            {
                panel1.Visible = true;
            }
        }
        private void comboBoxMunicipis_SelectedIndexChanged(object sender, EventArgs e)
        {
            var muni = (Municipi)comboBoxMunicipis.SelectedItem;
            viewmodelR.selectMunicipiActual(muni);
            comboBoxTaules.DataSource = viewmodelR.ListaTaulesMunicipi;
            viewmodelR.grabar();
        }
        private void comboBoxTaules_SelectedIndexChanged(object sender, EventArgs e)
        {
            var taula = (TaulaElectoral)comboBoxTaules.SelectedItem;
            viewmodelR.selectTaulaActual(taula);

            //No funciona
            if (viewmodelR.ActualResultat.votsTotals == null || viewmodelR.ActualResultat.votsTotals == 0)
            {
                FormVotsTotals formVotsTotals = new FormVotsTotals();
                //TODO: notworking el form de Resultats he dentrar resulats be
                if (formVotsTotals.ShowDialog() == DialogResult.OK)
                {
                    viewmodelR.ActualResultat.votsTotals = formVotsTotals.ResultatTaula.votsTotals;
                }
            }
            textBoxVotsTotals.DataBindings.Clear();
            textBoxVotsTotals.DataBindings.Add("Text", viewmodelR.ActualResultat, "votsTotals");
            textBoxVotsBlanc.DataBindings.Clear();
            textBoxVotsBlanc.DataBindings.Add("Text", viewmodelR.ActualResultat, "votsBlanc");
            textBoxVotsNuls.DataBindings.Clear();
            textBoxVotsNuls.DataBindings.Add("Text", viewmodelR.ActualResultat, "votsNul");

            dataGridViewVotsPartit.Refresh();
            viewmodelR.grabar();
        }
        private void FormResultados_FormClosing(object sender, FormClosingEventArgs e)
        {
            viewmodelR.grabar();
        }

        private void comboBoxMunicipis_MouseClick(object sender, MouseEventArgs e)
        {
            var check = viewmodelR.checkVots();
            if (check == false) { panelCheckingVots.Show(); }
        }

        private void buttonAviso_Click(object sender, EventArgs e)
        {
            panelCheckingVots.Visible = false;
        }

        private void comboBoxTaules_MouseClick(object sender, MouseEventArgs e)
        {
            var check = viewmodelR.checkVots();
            if (check == false) { panelCheckingVots.Show(); }
        }

        private void buttonDesarResultats_Click(object sender, EventArgs e)
        {
            viewmodelR.grabar();
        }
    }

}