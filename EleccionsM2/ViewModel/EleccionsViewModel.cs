using EleccionsM2.Models;
using EleccionsM2.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.ViewModel
{
    public class EleccionsViewModel
    {

        EleccionsM2.EleccionsMContext context;

        public List<Municipi> ListaMunicipis{ get; set; }
        public List<PartitMunicipi> ListaPartitsMunicipi { get=>ActualMunicipi.llistaPartits; }
        public List<Candidat> ListaCandidats { get=>ActualPartit.candidats; }
        public List<TaulaElectoral> ListaTaulesMunicipi { get => ActualMunicipi.taulesElectorals; }
        //amb el INotifyPropertyChanged podria ser més senzill ja que el binding nomes el faria un cop i cada cop que 
        //el ActualMunicipi canvi de valor será el foco i el binded.
        public Municipi ActualMunicipi { get; set; }
        public PartitMunicipi ActualPartit { get; set; }
        public Candidat ActualCandidat { get; set; }
        public TaulaElectoral ActualTaula { get; set; }
        public EleccionsViewModel()
        {
            context= new EleccionsMContext();
          
            ListaMunicipis = context.Municipis.Include(m=> m.llistaPartits).ThenInclude(c=>c.candidats).Include(t =>t.taulesElectorals).ToList();
        }
        public void Grabar()
        {
            context.SaveChanges();
        }
        public void idSelectedMostrarPartidosAndTaules(long idSelected)
        {
            int n = (int)idSelected;
            ActualMunicipi = ListaMunicipis.SingleOrDefault(m => m.ID == n);
            //ListaPartitsMunicipi = ActualMunicipi.llistaPartits.ToList();
            //ListaTaulesMunicipi = ActualMunicipi.taulesElectorals.ToList();
        }
        public void idSelectedPartidoMostrarCandidatos(long idSelected)
        {
            int n = (int)idSelected;
            ActualPartit = ListaPartitsMunicipi.SingleOrDefault(p => p.ID == n);
            //ListaCandidats = ActualPartit.candidats.ToList();
        }
        public void idSelectedCandidat(long idCandidat)
        {
            int n = (int) idCandidat;
            ActualCandidat = ListaCandidats.SingleOrDefault(c => c.ID == n);
        }
        public void idSelectedTaula(long idTaula)
        {
            int n = (int)idTaula;
            ActualTaula = ListaTaulesMunicipi.SingleOrDefault(t => t.ID == n);
        }
        public void VaciarListaCandidatos()
        {
            ListaCandidats.Clear();
        }
        //add functions..
        //(mal hecho el de municipios, pq es directo al context)
        public void addmunicipio(Municipi municipi)
        {
            context.Municipis.Add(municipi);
            ActualMunicipi = municipi;
            ListaMunicipis.Add(municipi);
            Grabar();
        }
        public void addPartit(PartitMunicipi partit)
        {
            ActualPartit = partit;
            //ActualMunicipi.llistaPartits.Add(ActualPartit);
            ListaPartitsMunicipi.Add(ActualPartit);
            Grabar();
        }
        public void addCandidat(Candidat candidat)
        {
            ActualCandidat = candidat;
            //ActualPartit.candidats.Add(ActualCandidat);
            ListaCandidats.Add(ActualCandidat);
            Grabar();
        }
        public void addTaula(TaulaElectoral taula)
        {
            ActualTaula = taula;
            //ActualMunicipi.taulesElectorals.Add(ActualTaula);
            ListaTaulesMunicipi.Add(ActualTaula);
            Grabar();
        }
        //delete functions
        public void eliminarMunicipi()
        {
            //Em passa lo mateix que amb el addmunicipio ho he de fer directe al context nose pq xd
            context.Municipis.Remove(ActualMunicipi);
            ListaMunicipis.Remove(ActualMunicipi);
        }
        public void eliminarPartit()
        {
            ActualMunicipi.llistaPartits.Remove(ActualPartit);
            ListaPartitsMunicipi.Remove(ActualPartit);
        }
        public void eliminarCandidat()
        {
            ActualPartit.candidats.Remove(ActualCandidat);
            ListaCandidats.Remove(ActualCandidat);
        }
        public void eliminarTaula()
        {
            ActualMunicipi.taulesElectorals.Remove(ActualTaula);
            ListaTaulesMunicipi.Remove(ActualTaula);
        }
    }
}
