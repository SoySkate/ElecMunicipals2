using EleccionsM2.Models;
using EleccionsM2.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace EleccionsM2.ViewModel
{
    public class EleccionsViewModel
    {

        EleccionsM2.EleccionsMContext context;

        public List<Municipi> ListaMunicipis{ get; set; }
        public List<PartitMunicipi> ListaPartitsMunicipi { get => ActualMunicipi.llistaPartits; }
        public List<Candidat> ListaCandidats { get=>ActualPartit.candidats; }
        public List<TaulaElectoral> ListaTaulesMunicipi { get => ActualMunicipi.taulesElectorals; }
        //amb el INotifyPropertyChanged podria ser més senzill ja que el binding nomes el faria un cop i cada cop que 
        //el ActualMunicipi canvi de valor será el foco i el binded.
        public Municipi? ActualMunicipi { get; set; } 
        public PartitMunicipi? ActualPartit { get; set; } = new PartitMunicipi();
        public Candidat? ActualCandidat { get; set; } = new Candidat();
        public TaulaElectoral? ActualTaula { get; set; } 
        public ResultatsTaula ActualResultat { get => ActualTaula.resultatsTaula; }

        public EleccionsViewModel()
        {
            context = new EleccionsMContext();
            ListaMunicipis = context.Municipis.Include(m => m.llistaPartits).ThenInclude(c => c.candidats).Include(t => t.taulesElectorals).ToList();
        }
        public async Task Grabar()
        {
            try { 
            context.SaveChanges();
            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        public void idSelectedMostrarPartidosAndTaules(long idSelected)
        {
            int n = (int)idSelected;
            try { 
            ActualMunicipi = ListaMunicipis.SingleOrDefault(m => m.ID == n);
            }
            catch { MessageBox.Show("Ningun municipio se ha podido seleccionar"); }
            //ListaPartitsMunicipi = ActualMunicipi.llistaPartits.ToList();
            //ListaTaulesMunicipi = ActualMunicipi.taulesElectorals.ToList();
        }
        public void idSelectedPartidoMostrarCandidatos(long idSelected)
        {
            int n = (int)idSelected;
            try
            {
                ActualPartit = ListaPartitsMunicipi.SingleOrDefault(p => p.ID == n);
            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        public void idSelectedCandidat(long idCandidat)
        {
            int n = (int) idCandidat;
            try {
            ActualCandidat = ListaCandidats.SingleOrDefault(c => c.ID == n);
            }
            catch { MessageBox.Show("Ningun candidato se ha podido seleccionar"); }
        }
        public void idSelectedTaula(long idTaula)
        {
            int n = (int)idTaula;
            try { 
            ActualTaula = ListaTaulesMunicipi.SingleOrDefault(t => t.ID == n);
            }
            catch { MessageBox.Show("Ninguna TaulaElectoral se ha podido seleccionar"); }
        }
        public void VaciarListaCandidatos()
        {
            ListaCandidats.Clear();
        }
        //add functions..
        //(mal hecho el de municipios, pq es directo al context)
        public async Task addmunicipio(Municipi municipi)
        {  
            ActualMunicipi = municipi;
            context.Municipis.Add(ActualMunicipi);
            await Grabar();
            ListaMunicipis.Add(ActualMunicipi);
        }
        public async Task addPartit(PartitMunicipi partit)
        {
            ActualPartit = partit;
            //ActualMunicipi.llistaPartits.Add(ActualPartit);
            ListaPartitsMunicipi.Add(ActualPartit);
            await Grabar();
        }
     
        public async Task addCandidat(Candidat candidat, string num)
        {
            int regidors = int.Parse(num);
            if (ActualPartit.candidats.Count < regidors) { 
            ActualCandidat = candidat;
            //ActualPartit.candidats.Add(ActualCandidat);
            ListaCandidats.Add(ActualCandidat);
            await Grabar();
            }
            else { MessageBox.Show("No puedes añadir mas candidatos que número de regidores."); }
        }
        public async Task addTaula(TaulaElectoral taula)
        {
            ActualTaula = taula;
            //ActualMunicipi.taulesElectorals.Add(ActualTaula);
            ListaTaulesMunicipi.Add(ActualTaula);
            await Grabar();
        }
        public async Task addResultatT(ResultatsTaula resultat)
        {
            ActualTaula.resultatsTaula = resultat;
            await Grabar();
        }
        //public async Task addResultatVotsPerLlista(List<VotsPerLlista> vots)
        //{
        //    foreach (VotsPerLlista vot in vots)
        //    {
        //        ListaVotsPerLlista.Add(vot);
        //    }
        //     await Grabar();
        //}
        //delete functions
        public async Task eliminarMunicipi()
        {
        //El problema crec que es als candiats
            //________________________
            //LO DE LES TAULES FUNCIONA.      
            foreach (TaulaElectoral taula in ListaTaulesMunicipi)
            {
                //context.ResultatsTaules.Remove(taula.resultatsTaula);
                //if (taula.resultatsTaula != null)
                //{
                //    context.ResultatsTaules.Remove(taula.resultatsTaula);
                //}                
                context.TaulesElectorals.Remove(taula);
            }
            ListaTaulesMunicipi.Clear();            
            //________________________
            //El partido solo creo que tambien funciona. Se lia en los candidatos
            foreach (PartitMunicipi partit in ListaPartitsMunicipi)
            {
                foreach (Candidat candi in partit.candidats)//potser ha de ser partit.candiats
                {
                    context.Candidats.Remove(candi);
                }
                ListaCandidats.Clear();
                context.PartitsPolitics.Remove(partit);
            }
            ListaPartitsMunicipi.Clear();

            ListaMunicipis.Remove(ActualMunicipi);
            context.Municipis.Remove(ActualMunicipi);
           

            await Grabar();            
        }
        public async Task eliminarPartit()
        {
            foreach (Candidat cand in ListaCandidats)
            {
                var item = context.Candidats.FirstOrDefault(x => x.ID == cand.ID);
                if (item != null)
                {
                    context.Candidats.Remove(item);
                }
            }
            ListaPartitsMunicipi.Remove(ActualPartit);
            context.PartitsPolitics.Remove(ActualPartit);
            await Grabar();
        }
        public async Task eliminarCandidat()
        {
            ListaCandidats.Remove(ActualCandidat);
            context.Candidats.Remove(ActualCandidat);
            //ActualPartit.candidats.Remove(ActualCandidat);
            await Grabar();
        }
        //falta per fer la delete on cascade xd
        public async Task eliminarTaula()
        {
            ListaTaulesMunicipi.Remove(ActualTaula);            
            context.TaulesElectorals.Remove(ActualTaula);
            //context.ResultatsTaules.Remove(ActualResultat);
            //ActualMunicipi.taulesElectorals.Remove(ActualTaula);
            await Grabar();
        }
    }
}
