using EleccionsM2.Models;

namespace EleccionsM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //crearContexto:
        EleccionsMContext Contexto1 = new EleccionsMContext();
        //objectes que utilitzo en memoria
        Municipi varMunicipi = new Municipi();
        PartitMunicipi varPartit = new PartitMunicipi();
        Candidat varCandidat = new Candidat();
        TaulaElectoral varTaula = new TaulaElectoral();
        //TODO:Butons and textBox:________________________________________________________________________________
        private void btnCarregarDades_Click(object sender, EventArgs e)
        {
            panelMunicipis.Show();
            carregarMunicipis();
        }
        //Close Form
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
            Contexto1.Dispose();
        }

        private void btnCrearMunicipi_Click(object sender, EventArgs e)
        {
            panelNomMunicipi.Show();
            varMunicipi = crearMunicipi();
            //comprobando lo del ID si se modifica o no...
            Contexto1.SaveChanges(); //me sale un error aqui
        }
        //salto de texto nomMunicipi hasta NumRegidors textbox.
        private void textBoxNomMunicipi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxNomMunicipi.Text != "" && textBoxNomMunicipi.Text != string.Empty)
            {
                panelNumRegidorsMunicipi.Show();
                textBoxNumRegidors.Focus();
                posarNomMunicipi();
            }
        }
        //salto de num regidors text hasta nom Partit
        private void textBoxNumRegidors_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonums(e);
        }
        private void textBoxNumRegidors_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && textBoxNumRegidors.Text != "" && textBoxNumRegidors.Text != string.Empty)
            {
                e.Handled = false;
                panelCandidatsPartitMunicipi.Show();
                textBoxNomPartit.Focus();
                posarNumRegidorsMunicipi();
            }

        }

        //salto de textboxNomPartit hasta textBoxNomCandidat
        private void textBoxNomPartit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxNomPartit.Text != "" && textBoxNomPartit.Text != string.Empty)
            {
                varPartit = crearPartit();
                Contexto1.SaveChanges();
                posarNomPartit();
                textBoxNomCandidat.Focus();
                Contexto1.SaveChanges();
            }
        }
        //cada keypress.enter meterá un Candidat en la listbox
        private void textBoxNomCandidat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxNomCandidat.Text != "" && textBoxNomCandidat.Text != string.Empty)
            {
                varCandidat = crearCandidat();
                Contexto1.SaveChanges();
                posarNomCandidat();
                CandidatsBox.Items.Add(varCandidat.ImprimirCandidat());
                textBoxNomCandidat.Text = string.Empty;
                Contexto1.SaveChanges();

                //funcion crearcandidat y meterlo en la listbox
            }
        }
        private void btnAfegirPartit_Click(object sender, EventArgs e)
        {
            /*PartitMunicipi trobantPartit = Contexto1.PartitsPolitics.SingleOrDefault(n=> n.ID==varPartit.ID);
            PartitsBox.Items.Add(trobantPartit.imprimirPartit());*/

            //com el partit ja esta a la base de dades y nomes el volem posar a la listbox per algo visual
            //ho podem fer desde la propia variable partit que esta en memoria...

            if (CandidatsBox.Items.Count == int.Parse(textBoxNumRegidors.Text))
            {
                PartitsBox.Items.Add(varPartit.imprimirPartit());
                CandidatsBox.Items.Clear();
                textBoxNomPartit.Text = string.Empty;
                panelLlistaPartits.Show();
            }
            else { MessageBox.Show("No hi ha la mateixa quantitat de regidors que de candidats."); }
        }
        //creartaula y showpanelTaules:
        private void btnAfegirTaules_Click(object sender, EventArgs e)
        {
            panelTaulesElectorals.Show();
            varTaula = crearTaula();
            Contexto1.SaveChanges();
            textBoxNomTaula.Focus();
        }
        private void textBoxNomTaula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxNomTaula.Text != "" && textBoxNomTaula.Text != string.Empty)
            {
                posarNomTaula();
                Contexto1.SaveChanges();
                textBoxCensTaula.Focus();
            }
        }
        private void textBoxCensTaula_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonums(e);
        }
        private void textBoxCensTaula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxCensTaula.Text != "" && textBoxCensTaula.Text != string.Empty)
            {
                e.Handled = false;
                posarCensTaula();
                TaulesBox.Items.Add(varTaula);
                textBoxNomTaula.Text = string.Empty;
                textBoxCensTaula.Text = string.Empty;
                textBoxNomTaula.Focus();
            }
        }
        private void btnEliminarCandidat_Click(object sender, EventArgs e)
        {
            eliminarCandidat();
        }
        private void btnEliminarPartit_Click(object sender, EventArgs e)
        {
            eliminarPartit();
        }
        private void btnEliminarTaula_Click(object sender, EventArgs e)
        {
            eliminarTaula();
        }

        //TODO:Functions:________________________________________________________________________________________

        public void carregarMunicipis() //button CarregarDades
        {
            MunicipisBox.Items.Clear();
            foreach (Municipi municipi in Contexto1.Municipis)
            {
                MunicipisBox.Items.Add(municipi.ImprimirDatosMunicipio());
            }
        }
        //crearMunicipi
        public Municipi crearMunicipi()
        {
            Municipi nouMunicipi = new Municipi();
            //potser aixo ara no es necesssari lo de posar valors buits.
            nouMunicipi.nomMunicipi = "";
            nouMunicipi.numeroRegidors = 0;
            Contexto1.Municipis.Add(nouMunicipi);
            textBoxNomMunicipi.Focus();
            return nouMunicipi;
        }
        //seleccionamos el municipio con el mismo ID y le ponemos el name (supuestamente)
        public void posarNomMunicipi()
        {
            //SingleOrDefault Ho podia fer amb un LINQ pero mes liat
            Municipi trobantMuni = Contexto1.Municipis.SingleOrDefault(n => n.ID == varMunicipi.ID);
            trobantMuni.nomMunicipi = textBoxNomMunicipi.Text;
            Contexto1.SaveChanges();

        }
        public void posarNumRegidorsMunicipi()
        {
            Municipi trobantMuni = Contexto1.Municipis.SingleOrDefault(n => n.ID == varMunicipi.ID);
            int num;
            try { num = int.Parse(textBoxNumRegidors.Text); } catch { MessageBox.Show("Nomes NUMEROS."); num = 0; }
            trobantMuni.numeroRegidors = num;
            Contexto1.SaveChanges();
        }
        //crearPartit
        public PartitMunicipi crearPartit()
        {
            PartitMunicipi nouPartit = new PartitMunicipi();
            nouPartit.nomPartit = "";
            Contexto1.PartitsPolitics.Add(nouPartit);
            return nouPartit;
        }
        //canviar nom i enviarlo al municipi que li pertoca
        public void posarNomPartit()
        {
            PartitMunicipi trobantPartit = Contexto1.PartitsPolitics.SingleOrDefault(n => n.ID == varPartit.ID);
            trobantPartit.nomPartit = textBoxNomPartit.Text;
            //I enviarlo al Municipi que li pertoca
            Municipi trobantMunicipi = Contexto1.Municipis.SingleOrDefault(n => n.ID == varMunicipi.ID);
            trobantMunicipi.llistaPartits.Add(trobantPartit);
        }
        //crearCandidat i posarli el nom a la mateixa funcio de crearlo.
        public Candidat crearCandidat()
        {
            Candidat nouCandidat = new Candidat();
            nouCandidat.nomCandidat = "";
            Contexto1.Candidats.Add(nouCandidat);
            return nouCandidat;
        }
        public void posarNomCandidat()
        {
            varCandidat.nomCandidat = textBoxNomCandidat.Text;//en memoria
            //PartitMunicipi trobantPartit = Contexto1.PartitsPolitics.SingleOrDefault(n => n.ID == varPartit.ID);
            Candidat trobantCandidat = Contexto1.Candidats.SingleOrDefault(n => n.ID == varCandidat.ID);
            trobantCandidat.nomCandidat = textBoxNomCandidat.Text;

            //entrar objecte candidat al partit a la database PartitPolitic Especific
            PartitMunicipi trobantPartit = Contexto1.PartitsPolitics.SingleOrDefault(n => n.ID == varPartit.ID);
            trobantPartit.candidats.Add(trobantCandidat);
        }
        public TaulaElectoral crearTaula()
        {
            TaulaElectoral novaTaula = new TaulaElectoral();
            novaTaula.nomTaula = "";
            novaTaula.censTaula = 0;
            Contexto1.TaulesElectorals.Add(novaTaula);
            MessageBox.Show(TaulesBox.Items.Count.ToString());
            return novaTaula;
        }
        public void posarNomTaula()
        {
            TaulaElectoral trobantTaula = Contexto1.TaulesElectorals.SingleOrDefault(n => n.ID == varTaula.ID);
            trobantTaula.nomTaula = textBoxNomTaula.Text;
            //en memorialocal:
            varTaula.nomTaula = textBoxNomTaula.Text;
        }
        //posar cens i pasar lobjecte al municipi corresponent
        public void posarCensTaula()
        {
            TaulaElectoral trobantTaula = Contexto1.TaulesElectorals.SingleOrDefault(n => n.ID == varTaula.ID);
            trobantTaula.censTaula = int.Parse(textBoxCensTaula.Text);
            //en memorialocal:
            varTaula.censTaula = int.Parse(textBoxCensTaula.Text);
            //enviar object al municipi object que li pertoca
            Municipi trobantMunicipi = Contexto1.Municipis.SingleOrDefault(n => n.ID == varMunicipi.ID);
            trobantMunicipi.taulesElectorals.Add(trobantTaula);
        }
        //restringir lletres
        public void solonums(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        public void eliminarCandidat()
        {
            string nomCandidat = CandidatsBox.SelectedItem.ToString();
            Candidat trobantCandidat = Contexto1.Candidats.SingleOrDefault(c => c.nomCandidat == nomCandidat);
            Contexto1.Candidats.Remove(trobantCandidat);
            Contexto1.SaveChanges();
            CandidatsBox.Items.RemoveAt(CandidatsBox.SelectedIndex);
        }
        public void eliminarPartit()
        {
            string nomPartit = PartitsBox.SelectedItem.ToString();
            PartitMunicipi trobantPartit = Contexto1.PartitsPolitics.SingleOrDefault(p => p.nomPartit == nomPartit);
            Contexto1.PartitsPolitics.Remove(trobantPartit);
            Contexto1.SaveChanges();
            PartitsBox.Items.RemoveAt(PartitsBox.SelectedIndex);
        }
        public void eliminarTaula()
        {
            TaulaElectoral taulavar = (TaulaElectoral)TaulesBox.SelectedItem;
            TaulaElectoral trobantTaula = Contexto1.TaulesElectorals.SingleOrDefault(t=> t.ID == taulavar.ID);
            Contexto1.TaulesElectorals.Remove(trobantTaula);
            Contexto1.SaveChanges();
            TaulesBox.Items.RemoveAt(TaulesBox.SelectedIndex);
            //HI HA ALGO QUE NO FUNCIONA EM SEMBLA, COMPROVARHO
            MessageBox.Show(TaulesBox.Items.Count.ToString());

        }

       
    }
}