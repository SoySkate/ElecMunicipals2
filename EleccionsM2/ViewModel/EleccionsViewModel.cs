using EleccionsM2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.ViewModel
{
    public class EleccionsViewModel
    {

        EleccionsM2.EleccionsMContext context;

        public List<Municipi> ListaMunicipis{ get; set; }
        public List<PartitMunicipi> ListaPartitsMunicipi { get; set; }
        public List<Candidat> ListaCandidats { get; set; }
        //public List<TaulaElectoral> ListaTaules { get; set; }
        //public List<ResultatsTaula> ListaResultats { get; set; }
        public Municipi ActualMunicipi { get; set; }
        public PartitMunicipi ActualPartit { get; set; }
        public Candidat ActualCandidat { get; set; }


        //public Municipi MunicipiSeleccionat { get; set; } = new Municipi();

        public EleccionsViewModel()
        {
            context= new EleccionsMContext();
          
            ListaMunicipis = context.Municipis.Include(m=> m.llistaPartits).ThenInclude(c=>c.candidats).ToList();
           
        }
        public void Grabar()
        {
            context.SaveChanges();
        }
        public void idSelectedMostrarPartidos(long idSelected)
        {
            int n = (int)idSelected;
            ActualMunicipi = ListaMunicipis.SingleOrDefault(m => m.ID == n);
            ListaPartitsMunicipi = ActualMunicipi.llistaPartits.ToList();
        }
        public void idSelectedPartidoMostrarCandidatos(long idSelected)
        {
            int n = (int)idSelected;
            ActualPartit = ListaPartitsMunicipi.SingleOrDefault(p => p.ID == n);
            ListaCandidats = ActualPartit.candidats.ToList();
        }
        public void idSelectedCandidat(long idCandidat)
        {
            int n = (int) idCandidat;
            ActualCandidat = ListaCandidats.SingleOrDefault(c => c.ID == n);
        }
        public void VaciarListaCandidatos()
        {
            ListaCandidats.Clear();
        }
        public Municipi passarMuncipiTxt()
        {
            return ActualMunicipi;
        }
        public PartitMunicipi passarPartitTxt()
        {
            return ActualPartit;
        }
        public Candidat passarCandidatTxt()
        {
            return ActualCandidat;
        }
    }
}
