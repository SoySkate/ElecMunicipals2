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
            if (viewmodelR.ListaMunicipis.Count > 0)
            {
                comboBoxMunicipis.DataSource = viewmodelR.ListaMunicipis;
            controlPanel();
            }

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
        private async void comboBoxTaules_SelectedIndexChanged(object sender, EventArgs e)
        {            
            var taula = (TaulaElectoral)comboBoxTaules.SelectedItem;
            viewmodelR.selectTaulaActual(taula);
            await viewmodelR.grabarResultadosPartits();
            await mostrarTaula();
            dataGridViewVotsPartit.DataSource = null;
            dataGridViewVotsPartit.DataSource = viewmodelR.ListaVisualVotsPerPartit;

            //No funciona
                                  
            if (viewmodelR.ActualResultat.votsTotals == null || viewmodelR.ActualResultat.votsTotals == 0)
            {
                FormVotsTotals formVotsTotals = new FormVotsTotals();
                if (formVotsTotals.ShowDialog() == DialogResult.OK)
                {
                    viewmodelR.ActualResultat.votsTotals = formVotsTotals.ResultatTaula.votsTotals;
                }
            }
            textBoxCensTaula.DataBindings.Clear();
            textBoxCensTaula.DataBindings.Add("Text", viewmodelR.ActualTaula, "censTaula");
            textBoxVotsTotals.DataBindings.Clear();
            textBoxVotsTotals.DataBindings.Add("Text", viewmodelR.ActualResultat, "votsTotals");
            textBoxVotsBlanc.DataBindings.Clear();
            textBoxVotsBlanc.DataBindings.Add("Text", viewmodelR.ActualResultat, "votsBlanc");
            textBoxVotsNuls.DataBindings.Clear();
            textBoxVotsNuls.DataBindings.Add("Text", viewmodelR.ActualResultat, "votsNul");
        
            //dataGridViewVotsPartit.Refresh();
            await viewmodelR.grabar();
            
        }
        public async Task mostrarTaula()
        {
            await viewmodelR.printarTaula();
            await Task.Delay(1000);
        }
        private async void FormResultados_FormClosing(object sender, FormClosingEventArgs e)
        {
            await viewmodelR.grabarResultadosPartits();
            await viewmodelR.grabar();
        }

        private async void comboBoxMunicipis_MouseClick(object sender, MouseEventArgs e)
        {
            await viewmodelR.grabarResultadosPartits();
        }

        private void buttonAviso_Click(object sender, EventArgs e)
        {
            panelCheckingVots.Visible = false;
        }

        private async void comboBoxTaules_MouseClick(object sender, MouseEventArgs e)
        {
            if (viewmodelR.ActualMunicipi != null)
            {
                var check = viewmodelR.checkVots();
            if (check == false) { panelCheckingVots.Show(); }
            await viewmodelR.grabarResultadosPartits();
            }
        }

        private async void buttonDesarResultats_Click(object sender, EventArgs e)
        {
            await viewmodelR.grabarResultadosPartits();
            await viewmodelR.grabar();
        }
    }

}