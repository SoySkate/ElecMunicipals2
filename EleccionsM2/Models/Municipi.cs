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
        //aqui en el constructor buit inicialtzo la List que no sabia que s'havia de fer xdd 
        public Municipi() { llistaPartits = new List<PartitMunicipi>(); taulesElectorals = new List<TaulaElectoral>(); }

        //public Municipi(string nomMunicipi, int numeroRegidors,List<PartitMunicipi> llistaPartits, List<TaulaElectoral> taulaElectoral)
        //{
        //    this.nomMunicipi = nomMunicipi;
        //    this.numeroRegidors = numeroRegidors;
        //    this.llistaPartits = llistaPartits;
        //    this.taulesElectorals = taulaElectoral;
        //}

        public string ImprimirDatosMunicipio()
        {
            return "-" + nomMunicipi + "  -Regidors: " + numeroRegidors + " -TaulesElec: ";//+ taulesElectorals.Count();
        }
        
        public override string ToString()
        {
            return "-" + nomMunicipi + "  -Regidors: " + numeroRegidors + " -TaulesElec: ";//+ taulesElectorals.Count();
        }
        public void borrarDatos()
        {
            ID = 0;
            nomMunicipi = string.Empty;
            numeroRegidors = 0;
            llistaPartits.Clear();
            taulesElectorals.Clear();
        }
    }
}
