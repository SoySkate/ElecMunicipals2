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
        public List<EsconsPartitViewModel> ListaEsconsPartit { get; set; }
        public List<TaulaDadesViewModel> ListaTaulaDades { get; set; }
        public List<RegidorsViewModel> ListaRegidors { get; set; }
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
            VotsPartitsTotals = VotsValidsTotals - vb;//potser aqui no funca
        }

    }
}
