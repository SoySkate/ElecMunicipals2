using EleccionsM2.Models;

namespace EleccionsM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Municipi varMunicipi = new Municipi();
        //TODO:Butons and textBox:________________________________________________________________________________
        private void btnCarregarDades_Click(object sender, EventArgs e)
        {
            panelMunicipis.Show();
            carregarMunicipis();
        }

        private void btnCrearMunicipi_Click(object sender, EventArgs e)
        {
            panelNomMunicipi.Show();
            varMunicipi = crearMunicipi();
        }
        //salto de texto nomMunicipi hasta NumRegidors textbox.
        private void textBoxNomMunicipi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxNomMunicipi.Text != "")
            {
                panelNumRegidorsMunicipi.Show();
                textBoxNumRegidors.Focus();
                posarNomMunicipi();
            }
        }
        //salto de num regidors text hasta nom Partit
        private void textBoxNumRegidors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxNomMunicipi.Text != "")
            {
                panelCandidatsPartitMunicipi.Show();
                textBoxNomPartit.Focus();
                posarNumRegidorsMunicipi();
                //nadasoloparaversifuncionanlasfuncs para entrar datos nombre y numregidores al objetoxd:
                foreach(Municipi municipi in Contexto1.Municipis)
                {
                    MunicipisBox.Items.Add(municipi.ImprimirDatosMunicipio());
                }
            }
        }
        //salto de textboxNomPartit hasta textBoxNomCandidat
        private void textBoxNomPartit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxNomMunicipi.Text != "")
            {
                textBoxNomCandidat.Focus();
            }
        }
        //cada keypress.enter meterá un Candidat en la listbox
        private void textBoxNomCandidat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxNomMunicipi.Text != "")
            {
                //funcion crearcandidat y meterlo en la listbox
            }
        }

        //TODO:Functions:________________________________________________________________________________________
        EleccionsMContext Contexto1 = new EleccionsMContext();
       
        public void carregarMunicipis() //button CarregarDades
        {
            foreach (Municipi municipi in Contexto1.Municipis)
            {
                MunicipisBox.Items.Add(municipi);
            }
        }
        public Municipi crearMunicipi()
        {
            Municipi nouMunicipi = new Municipi();
            Contexto1.Municipis.Add(nouMunicipi);
            textBoxNomMunicipi.Focus();
            return nouMunicipi;
        }
        //seleccionamos el municipio con el mismo ID y le ponemos el name (supuestamente)
        public void posarNomMunicipi()
        {
            var queryIdMunicipi = from muni in Contexto1.Municipis
                                  where muni.ID == varMunicipi.ID
                                  select muni;
            queryIdMunicipi.ToList().ForEach(n =>n.nomMunicipi = textBoxNomMunicipi.Text);                   
        }
        public void posarNumRegidorsMunicipi()
        {
            var queryIdMunicipi = from muni in Contexto1.Municipis
                                  where muni.ID == varMunicipi.ID
                                  select muni;
            queryIdMunicipi.ToList().ForEach(n => n.numeroRegidors = int.Parse(textBoxNumRegidors.Text));
        }

      
    }
}