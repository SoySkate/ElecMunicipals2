using EleccionsM2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.ViewModel
{
    public class ResultatsViewModel
    {
        EleccionsMContext Rcontext;
        public List<Municipi> ListaMunicipis { get; set; }
        public List<PartitMunicipi> ListaPartitsMunicipi { get =>ActualMunicipi.llistaPartits; }
        public List<Candidat> ListaCandidats { get => ActualPartit.candidats; }
        public List<TaulaElectoral> ListaTaulesMunicipi { get => ActualMunicipi.taulesElectorals; }
        public List<VotsPerLlista> ListaVotsPerLlista { get => ActualTaula.resultatsTaula.votsLlista; }

        //Esta lista es la que se ve en el formulario: ListaVisualVotsPerPartit
        public List<VotsPerLlistaViewModel> ListaVisualVotsPerPartit { get; set; }
        public Municipi ActualMunicipi { get; set; }
        public PartitMunicipi ActualPartit { get; set; }
        public TaulaElectoral ActualTaula { get; set; }
        public VotsPerLlista ActualVots { get; set; } = new();


        public ResultatsViewModel() {
           
            Rcontext = new EleccionsMContext();
            ListaMunicipis = Rcontext.Municipis.Include(p => p.llistaPartits).Include(t => t.taulesElectorals).ThenInclude(r => r.resultatsTaula).ThenInclude(v => v.votsLlista).ToList();
            //passarPartitsVotsViewModel();
        }
        public async Task grabar()
        {
            try
            {
                Rcontext.SaveChanges();
            }catch (Exception ex) { MessageBox.Show(ex.Message);}
        }
        public void selectMunicipiActual(Municipi selectedMuni)
        {
            ActualMunicipi = selectedMuni;
        }
        public void selectTaulaActual(TaulaElectoral selectedTaula)
        {
            ActualTaula = selectedTaula;
        }
        //public void passarPartitsVotsViewModel()
        //{
        //    VotsPerLlistaViewModel vots = new();
        //    foreach (Municipi muni in ListaMunicipis)
        //    {
        //        ActualMunicipi = muni;
        //        foreach (PartitMunicipi partit in ListaPartitsMunicipi)
        //        {                    
        //            vots.nomPartit = partit.nomPartit;
        //            ListaVisualVotsPerPartit.Add(vots);
        //        }
        //    }
        //}
    }
}
