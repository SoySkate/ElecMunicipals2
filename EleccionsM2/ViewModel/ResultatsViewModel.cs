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
        public ResultatsTaula ActualResultat { get => ActualTaula.resultatsTaula; }
        //crec que la listavotsperlilista esta mal el getter y el setter que? nose no crec que sigui de
        //ActualTaula.resultatsTaula.votsLlista
        public List<VotsPerLlista> ListaVotsPerLlista { get => ActualTaula.resultatsTaula.votsLlista; }

        //Esta lista es la que se ve en el formulario: ListaVisualVotsPerPartit
        public List<VotsPerLlistaViewModel> ListaVisualVotsPerPartit { get; set; } = new();
        public Municipi ActualMunicipi { get; set; }
        public PartitMunicipi ActualPartit { get; set; }
        public TaulaElectoral ActualTaula { get; set; }
        public VotsPerLlista ActualVot { get; set; } = new();

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
        public async Task printarTaula() {
            //per aqui sestan creant els partits del municipi1 al altre municipi2            
            ListaVisualVotsPerPartit.Clear();
           foreach (PartitMunicipi partit in ListaPartitsMunicipi)
           {
                ActualPartit = partit;
                VotsPerLlista vots = new();
                //VotsPerLlistaViewModel votsVM = new();
                //crear vots ho he ficat dins del if
                if (ListaVotsPerLlista.Exists(x => x.Partit.nomPartit == partit.nomPartit) == false)
                {                  
                        vots.Partit = ActualPartit;
                        vots.numeroVotsLlista = 0;
                        ListaVotsPerLlista.Add(vots);                   
                }
            }
            await grabar();
            foreach (VotsPerLlista vot in ListaVotsPerLlista)
            {
                if (ListaVisualVotsPerPartit.Exists(m => m.ID == vot.ID) == false)
                {
                    VotsPerLlistaViewModel nuevoitem = new();
                    //long id = vot.ID;
                    //string nom = vot.Partit.nomPartit;
                    //int num = vot.numeroVotsLlista;
                    nuevoitem.ID = vot.ID;
                    nuevoitem.nomPartit = vot.Partit.nomPartit;
                    nuevoitem.numeroVotsPartit = vot.numeroVotsLlista;
                    //El if es ignorable:
                    if (ListaVisualVotsPerPartit.Exists(i => i == nuevoitem) == false)
                    {
                        ListaVisualVotsPerPartit.Add(nuevoitem);
                    }
                }
            }
            await grabar();
        }
        public async Task grabarResultadosPartits()
        {
            foreach (VotsPerLlistaViewModel votVM in ListaVisualVotsPerPartit)
            {
                var vot = ListaVotsPerLlista.SingleOrDefault(v => v.ID == votVM.ID);
                if (vot != null)
                {
                    vot.numeroVotsLlista = votVM.numeroVotsPartit;             
                }
            }
            await grabar();
        }
        public bool checkVots()
        {
            int votsllista=0;
            foreach(VotsPerLlista vot in ActualResultat.votsLlista)
            {
                votsllista+=vot.numeroVotsLlista;
            }
            bool check= true;
            int suma = ActualResultat.votsBlanc + ActualResultat.votsNul + votsllista;
            if (suma != ActualResultat.votsTotals)
            {
                check = false;
                return check;
            }
            else { 
            return check;
            }
        }
    }
}
