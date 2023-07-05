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
        Municipi varMunicipi = new Municipi();
        PartitMunicipi varPartit = new PartitMunicipi();
        Candidat varCandidat = new Candidat();
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
            //comprobando lo del ID si se modifica o no...
            Contexto1.SaveChanges(); //me sale un error aqui
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
            }
        }
        //salto de textboxNomPartit hasta textBoxNomCandidat
        private void textBoxNomPartit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxNomMunicipi.Text != "")
            {
                varPartit = crearPartit();
                Contexto1.SaveChanges();
                posarNomPartit();
                textBoxNomCandidat.Focus();
            }
        }
        //cada keypress.enter meterá un Candidat en la listbox
        private void textBoxNomCandidat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxNomMunicipi.Text != "")
            {
                varCandidat = crearCandidat();
                Contexto1.SaveChanges();
                posarNomCandidat();
                //posarcandidatalpartit?
                CandidatsBox.Items.Add(varCandidat.ImprimirCandidat());
                textBoxNomCandidat.Text = string.Empty;

                //funcion crearcandidat y meterlo en la listbox
            }
        }
        private void btnAfegirPartit_Click(object sender, EventArgs e)
        {
            /*PartitMunicipi trobantPartit = Contexto1.PartitsPolitics.SingleOrDefault(n=> n.ID==varPartit.ID);
            PartitsBox.Items.Add(trobantPartit.imprimirPartit());*/

            //com el partit ja esta a la base de dades y nomes el volem posar a la listbox per algo visual
            //ho podem fer desde la propia variable partit que esta en memoria...
            PartitsBox.Items.Add(varPartit.imprimirPartit());
            CandidatsBox.Items.Clear();
            textBoxNomPartit.Text = string.Empty;
            panelLlistaPartits.Show();
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
            trobantMuni.numeroRegidors = int.Parse(textBoxNumRegidors.Text);
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
            Contexto1.SaveChanges();
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



    }
}