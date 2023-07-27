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
        public List<ResultatsTaula> ListaResultats { get; set; }
        public List<VotsPerLlista> ListaVotsPerLlista { get => ActualTaula.resultatsTaula.votsLlista; }

        //Esta lista es la que se ve en el formulario: ListaVisualVotsPerPartit
        public List<VotsPerLlistaViewModel> ListaVisualVotsPerPartit { get; set; } = new();
        public Municipi ActualMunicipi { get; set; }
        public PartitMunicipi ActualPartit { get; set; }
        public TaulaElectoral ActualTaula { get; set; }
        public ResultatsTaula ActualResultat { get; set; }
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
            ActualResultat= selectedTaula.resultatsTaula;
        }
        public async Task passarPartitsVotsViewModel()
        {
            ListaVisualVotsPerPartit.Clear();
           foreach (PartitMunicipi partit in ListaPartitsMunicipi)
           {
                     ActualPartit = partit;
                     VotsPerLlista vots = new();
                     VotsPerLlistaViewModel votsVM = new();
                //Pensava que creant lobjecte aquest que si esta a la database es posaria un id xd i podria copiarlo al altre
                if (ListaVotsPerLlista.Exists(x => x.Partit.nomPartit == partit.nomPartit) == false)
                {   
                        vots.Partit = ActualPartit;
                        vots.numeroVotsLlista = 0;
                        ListaVotsPerLlista.Add(vots);
                        await grabar();
                }
                //if (ListaVisualVotsPerPartit.Exists(l => l.nomPartit == votsVM.nomPartit) == false)
                //{
                //    votsVM.ID = vots.ID;
                //    votsVM.nomPartit = ActualPartit.nomPartit;
                //    votsVM.numeroVotsPartit = 0;
                //    ListaVisualVotsPerPartit.Add(votsVM);
                //    await grabar();
                //}
                //else { MessageBox.Show("ListavotsVM: "+ListaVisualVotsPerPartit.Count.ToString()); }

           }
        
            foreach(VotsPerLlista vot in ListaVotsPerLlista)
            {
                if (ListaVisualVotsPerPartit.Exists(m => m.ID == vot.ID) == false)
                {
                    VotsPerLlistaViewModel nuevoitem = new();
                    long id = vot.ID;
                    string nom = vot.Partit.nomPartit;
                    int num = vot.numeroVotsLlista;
                    nuevoitem.ID = id;
                    nuevoitem.nomPartit = nom;
                    nuevoitem.numeroVotsPartit = num;
                    if (ListaVisualVotsPerPartit.Exists(i => i == nuevoitem) == false)
                    {
                        ListaVisualVotsPerPartit.Add(nuevoitem);
                    }
                }
            }
        }
        //donde uso esto? por cierto creo que no funciona bien xd
        public async Task getDataGridResults()
        {
            MessageBox.Show(ListaVisualVotsPerPartit.Count.ToString());
            foreach(VotsPerLlistaViewModel votVM in ListaVisualVotsPerPartit)
            {
                VotsPerLlista item = new();
                //singleordefault use it;))
                long id =votVM.ID;
                var partit = ListaPartitsMunicipi.SingleOrDefault(p=>p.nomPartit== votVM.nomPartit);
                int num = votVM.numeroVotsPartit;
                item.ID = id;
                if (partit != null)
                {
                    item.Partit = partit;
                }
                item.numeroVotsLlista=num;
                if(ListaVotsPerLlista.Exists(i=>i==item)==false)
                {
                    ListaVotsPerLlista.Add(item);
                    await grabar();
                }
            }
        }
    }
}
