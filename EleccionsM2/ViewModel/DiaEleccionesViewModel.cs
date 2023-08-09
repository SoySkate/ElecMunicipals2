using EleccionsM2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.ViewModel
{
    public class DiaEleccionesViewModel
    {
        EleccionsMContext context;

        public List<Municipi> ListaMunicipis { get; set; }
        public List<PartitMunicipi> ListaPartitsMunicipi { get => ActualMunicipi.llistaPartits; }
        public List<Candidat> ListaCandidats { get => ActualPartit.candidats; }
        public List<TaulaElectoral> ListaTaulesMunicipi { get => ActualMunicipi.taulesElectorals; }
        //_________________________________________
        public List<EsconsPartitViewModel> ListaEsconsPartit { get; set; } = new();
        public List<TaulaDadesViewModel> ListaTaulaDades { get; set; } = new();
        public List<RegidorsViewModel> ListaRegidors { get; set; } = new();
        //_________________________________________

        //public ResultatsTaula ActualResultat { get => ActualTaula.resultatsTaula; }
        public Municipi ActualMunicipi { get; set; }
        public PartitMunicipi ActualPartit { get; set; }
        public TaulaElectoral ActualTaula { get; set; }
        //_________________________________________
        public double Participacio=0;
        public double Escrotat = 0;
        public int VotsTotals = 0;
        public int VotsValidsTotals = 0;
        public int VotsPartitsTotals = 0;
        public int VotsBlancsTotals = 0;
        public int VotsNulsTotals = 0;
        public double Abstencio = 0;
        public double minimVots=0;
        public int EsconsRepartir = 0;
        public int count = 0;
        //problema actual %Escrotat com lagafo? ESCROTAT
        //I els escons com els calculo aqui  ESCONS 


        public DiaEleccionesViewModel()
        {
            context = new EleccionsMContext();
            ListaMunicipis = context.Municipis.Include(p => p.llistaPartits).ThenInclude(c => c.candidats).Include(t => t.taulesElectorals).ThenInclude(r => r.resultatsTaula).ThenInclude(v => v.votsLlista).ToList();
        }
        public async Task grabar()
        {
            try
            {
                context.SaveChanges();
            }catch(Exception ex) { MessageBox.Show(ex.ToString());}
        }
        public void selectedMunicipi(Municipi muni)
        {
            ActualMunicipi = muni;
        }
        public void calcularDades()
        {
            //entrant les public dades de actual municipi
            double c = 0;
            double vt = 0;
            int vn = 0;
            int vb = 0;
            double p;
            double a;
            foreach(TaulaElectoral taula in ListaTaulesMunicipi)
            {
                c += taula.censTaula;
                vt += taula.resultatsTaula.votsTotals;                
                vn += taula.resultatsTaula.votsNul;
                vb += taula.resultatsTaula.votsBlanc;
            }
            VotsTotals = (int)vt;
            VotsBlancsTotals = vb;
            VotsNulsTotals = vn;
            p = (vt/c)*100;  
            Participacio=Math.Round(p,2);
            a = 100 - p;
            Abstencio = Math.Round(a, 2);
            VotsValidsTotals = (int)vt - vn;
            VotsPartitsTotals = VotsValidsTotals - vb;
            minimVots = VotsValidsTotals * 0.05;
            int numEscons = ActualMunicipi.numeroRegidors;
            EsconsRepartir = numEscons;
        }
        public async Task visualitzarEscons()
        {
            ListaEsconsPartit.Clear();
           
            foreach(TaulaElectoral t in ListaTaulesMunicipi)
            {
                //int count = 0;
                foreach(VotsPerLlista v in t.resultatsTaula.votsLlista)
                {              
                        EsconsPartitViewModel nouItemEscons = new();
                        string nom = v.Partit.nomPartit;
                        int numV= v.numeroVotsLlista;
                        nouItemEscons.nomPartit = nom;
                        nouItemEscons.numeroVots = numV;
                    
                        var partit = ListaPartitsMunicipi.SingleOrDefault(p=>p.nomPartit == nom);
                    nouItemEscons.ID = partit.ID;

                    if (ListaEsconsPartit.Exists(i => i.nomPartit == nouItemEscons.nomPartit) == true)
                    {
                        var sameItem = ListaEsconsPartit.SingleOrDefault(i => i.nomPartit == nouItemEscons.nomPartit);
                        sameItem.numeroVots += nouItemEscons.numeroVots;
                    }
                    else { ListaEsconsPartit.Add(nouItemEscons); }
                    //ordenar la list per qui tingui mes votacions
                    ListaEsconsPartit.Sort((p1, p2) => p2.numeroVots.CompareTo(p1.numeroVots));
                    await grabar();

                }
            }
        }
        public void AsignarEscons()
        {
            //intentant fer el mateix pero mes facil crec*******
            List<List<double>> listaTest = new();
            foreach(EsconsPartitViewModel e in ListaEsconsPartit)
            {
                List<double> listaP = new();
                for(int i=1; i < EsconsRepartir +1; i++)
                {
                   var result= e.numeroVots / i;
                    listaP.Add(result);
                }
                listaTest.Add(listaP);
            }
            foreach(List<double> list in listaTest)
            {

            }












            //Aixo ho he de fer fora daquest foreach de les taules una cosa es imprimir i ordenar i laltre calcular escons....................
            ///reparto descons            
            //bool repartit = false;
            //if (nouItemEscons != null) { 
           
            //    for (int i = 0; i < EsconsRepartir; i++)
            //    {                   
            //        double result = nouItemEscons.numeroVots / count;
            //        while (result > minimVots && EsconsRepartir != 0)
            //        {
            //            //Esto es probable que no funcione ya que solo toma un partido para repartir escons no??????????????????????????????????????????
            //            nouItemEscons.escons++;
            //            EsconsRepartir--;
            //            repartit = true;
            //            return repartit;
            //        }
            //            //if (EsconsRepartir == ActualMunicipi.numeroRegidors) { break; }
            //    }
            //        return repartit;
            //}
            //else { return repartit; }
            //if (repartit == true) { return repartit; } else { return repartit; }
        }

    }
}