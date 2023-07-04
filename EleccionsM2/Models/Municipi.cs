using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.Models
{
    public class Municipi
    {
        public long ID { get; set; }
        public string nomMunicipi { get; set; }
        public int numeroRegidors { get; set; }
        //Potser la list de llista partits del municipi té més sentit...?
        public List<PartitMunicipi> llistaPartits { get; set; }
        public List<TaulaElectoral> taulesElectorals { get; set; }
        public Municipi() { }
        public Municipi(string nomMunicipi, int numeroRegidors, List<TaulaElectoral> taulaElectoral)
        {
            this.nomMunicipi = nomMunicipi;
            this.numeroRegidors = numeroRegidors;
            this.taulesElectorals = taulaElectoral;
        }

        public string ImprimirDatosMunicipio()
        {
            return "-" + nomMunicipi + "  -Regidors: " + numeroRegidors + " -TaulesElec: " + taulesElectorals.Count();
        }
    }
}
