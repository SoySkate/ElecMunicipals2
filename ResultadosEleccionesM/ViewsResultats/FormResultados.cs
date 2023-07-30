using EleccionsM2.Models;
using EleccionsM2.ViewModel;
using EleccionsM2;


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
        }
        private void comboBoxTaules_SelectedIndexChanged(object sender, EventArgs e)
        {
            var taula = (TaulaElectoral)comboBoxTaules.SelectedItem;
            viewmodelR.selectTaulaActual(taula);
            //if (viewmodelR.ActualTaula.resultatsTaula.votsTotals != null) { panelMainModal.Show(); }
            //textBoxNumVotsTotals.DataBindings.Clear();
            //textBoxNumVotsTotals.DataBindings.Add("Text", viewmodelR.ActualTaula.resultatsTaula.votsTotals, "votsTotals");
            textBoxVotsBlanc.DataBindings.Clear();
            textBoxVotsBlanc.DataBindings.Add("Text", viewmodelR.ActualResultat, "votsBlanc");
            textBoxVotsNuls.DataBindings.Clear();
            textBoxVotsNuls.DataBindings.Add("Text", viewmodelR.ActualResultat, "votsNul");
            dataGridViewVotsPartit.Refresh();
        }
        private void FormResultados_FormClosing(object sender, FormClosingEventArgs e)
        {
            viewmodelR.grabar();
        }

        //private void buttonAddTotalVots_Click(object sender, EventArgs e)
        //{
        //    panelMainModal.Visible = false;
        //}
    }

}