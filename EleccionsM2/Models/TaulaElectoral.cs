using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.Models
{
    public class TaulaElectoral
    {
        public long ID { get; set; }
        public string nomTaula { get; set; }
        public int censTaula { get; set; }
        public ResultatsTaula? resultatsTaula { get; set; }

        public TaulaElectoral() { resultatsTaula = new(); }
        //public TaulaElectoral(string nomTaula, int censTaula, ResultatsTaula resultatsTaula)
        //{
        //    this.nomTaula = nomTaula;
        //    this.censTaula = censTaula;
        //    this.resultatsTaula = resultatsTaula;
        //}
        public string ImprimirNomICensTaula()
        {
            return "Nom: " + nomTaula + "  Cens: " + censTaula;
        }

        public override string ToString()
        {
            return "Nom: " + nomTaula + "  Cens: " + censTaula;
        }

        public void borrarDatos()
        {
            ID = 0;
            nomTaula = string.Empty;
            censTaula = 0;
            //no cal borrar res de resultats taula pq no els he de controlar per aqui
        }
    }
}
