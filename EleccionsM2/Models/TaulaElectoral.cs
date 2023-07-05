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
        public ResultatsTaula resultatsTaula { get; set; }

        public TaulaElectoral() { }
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
        //desde aqui imprimeixo la llista de resultats taula? o no?
    }
}
