﻿using EleccionsM2.Models;
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
        public List<VotsPerLlista> VotsPartitPerTaula { get => ActualTaula.resultatsTaula.votsLlista; }
        //_________________________________________
        public List<EsconsPartitViewModel> ListaEsconsPartit { get; set; } = new();
        public List<ResultatsTaula> ListaResultatsDades { get; set; } = new();
        public List<RegidorsViewModel> ListaRegidors { get; set; } = new();
        //_________________________________________

        //public ResultatsTaula ActualResultat { get => ActualTaula.resultatsTaula; }
        public Municipi ActualMunicipi { get; set; }
        public PartitMunicipi ActualPartit { get; set; }
        public TaulaElectoral ActualTaula { get; set; }
        public TaulaDadesViewModel ActualDadesTaula { get; set; }
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
        public void selectedTaula(TaulaElectoral taula)
        {
            ActualTaula = taula;
            ListaResultatsDades.Clear();
            ListaResultatsDades.Add(ActualTaula.resultatsTaula);
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
                double percentatgeV = 0;
                foreach(VotsPerLlista v in t.resultatsTaula.votsLlista)
                {
                    //aqui no esta agafant be els vots dels partits m'agafa de tots
                        EsconsPartitViewModel nouItemEscons = new();
                        string nom = v.Partit.nomPartit;
                        int numV = v.numeroVotsLlista;
                        nouItemEscons.nomPartit = nom;
                        nouItemEscons.numeroVots = numV;
                    //nouItemEscons.pVots = s;
                    //______________________
                    percentatgeV = ((double)v.numeroVotsLlista / (double)VotsPartitsTotals) * 100;
                    double firstPercent = Math.Round(percentatgeV, 2);
                    nouItemEscons.pVots = firstPercent;

                    var partit = ListaPartitsMunicipi.SingleOrDefault(p=>p.nomPartit == nom);
                        nouItemEscons.ID = partit.ID;

                    if (ListaEsconsPartit.Exists(i => i.nomPartit == nouItemEscons.nomPartit) == true)
                    {
                        var sameItem = ListaEsconsPartit.SingleOrDefault(i => i.nomPartit == nouItemEscons.nomPartit);
                        sameItem.numeroVots += nouItemEscons.numeroVots;
                        percentatgeV = ((double)sameItem.numeroVots / (double)VotsPartitsTotals) * 100;
                        double pround = Math.Round(percentatgeV, 2);
                        sameItem.pVots = pround;
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
            ////________________________________
            List<ListaCalculEsconsViewModel> listaTest = new();
            foreach (EsconsPartitViewModel e in ListaEsconsPartit)
            {
                ListaCalculEsconsViewModel listaP = new();
                listaP.ID = e.ID;
                for (int i = 1; i < ActualMunicipi.numeroRegidors + 1; i++)
                {
                    double result = e.numeroVots / i;
                    listaP.escoDividit.Add(result);
                }
                listaTest.Add(listaP);
            }
            int lastIteration = 0;
            int posi = 0;
            int listmesgran = 0;
            listaTest.Sort((e1, e2) => e2.escoDividit[0].CompareTo(e1.escoDividit[0]));
            
            for (int i = 0; i < ActualMunicipi.numeroRegidors; i++)
            {
                foreach (ListaCalculEsconsViewModel list in listaTest)
                {
                    //millorable la forma de seleccionar MOLT MILLORABLE (NECESSARI)
                    //TODO: (NECESSARI)(NECESSARI)(NECESSARI)(NECESSARI)(NECESSARI)(NECESSARI)
                    var partitEsco = ListaEsconsPartit.SingleOrDefault(p => p.ID == list.ID);
                    lastIteration++;
                    if (posi < list.escoDividit.Count)
                    {
                        if (list.escoDividit[posi] != null)
                        {

                            if (list.escoDividit[posi] > minimVots)
                            {
                                if (EsconsRepartir != 0)
                                {
                                    partitEsco.escons++;
                                    EsconsRepartir--;
                                }
                            }
                        }
                    }
                }
                posi++;
            }
        }
        public void seleccionarCandidats()           
        {
            ListaRegidors.Clear();
            ListaEsconsPartit.Sort((p1, p2) => p2.numeroVots.CompareTo(p1.numeroVots));
            foreach (EsconsPartitViewModel e in ListaEsconsPartit)
            {
                var partit = ListaPartitsMunicipi.SingleOrDefault(p=>p.ID== e.ID);
                if(e.escons != 0)
                {
                    for(int i=0; i < e.escons; i++)
                    {
                        RegidorsViewModel regi = new RegidorsViewModel();
                        regi.ID = partit.candidats[i].ID;
                        regi.nomCandiat = partit.candidats[i].nomCandidat;
                        regi.nomPartit = partit.nomPartit;
                        
                        ListaRegidors.Add(regi);
                    }
                }
            }
        }
        public void dadesTaula()
        {
            TaulaDadesViewModel TaulaDades = new();
            TaulaDades.ID = ActualTaula.ID;
            int sumavots = 0;
            double percent = ((double)ActualTaula.resultatsTaula.votsTotals / (double)ActualTaula.censTaula) * 100;
           
            TaulaDades.VotsNuls = ActualTaula.resultatsTaula.votsNul;
            TaulaDades.VotsBlancs = ActualTaula.resultatsTaula.votsBlanc;
            TaulaDades.VotsTotals = ActualTaula.resultatsTaula.votsTotals;
            foreach(VotsPerLlista v in ActualTaula.resultatsTaula.votsLlista)
            {
                sumavots += v.numeroVotsLlista;
            }
            int vescrotat = sumavots + ActualTaula.resultatsTaula.votsNul + ActualTaula.resultatsTaula.votsBlanc;
            //potser s ha de fer una var pel mig el tem percentatges
            TaulaDades.VotsEscrotats = vescrotat ;
            if (ActualTaula.resultatsTaula.votsTotals != 0) { 
            TaulaDades.Escrotat = (vescrotat / ActualTaula.resultatsTaula.votsTotals) * 100;
            }
            //la participacio i el escrotat% es lo mismo no? no lo es
            TaulaDades.Participació = Math.Round(percent, 2);

            ActualDadesTaula = TaulaDades;
            
        }
    }
}