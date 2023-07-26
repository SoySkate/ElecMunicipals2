using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.Models
{
    public class PartitMunicipi
    {
        public long ID { get; set; }
        public string nomPartit { get; set; }
        public List<Candidat> candidats { get; set; }

        public PartitMunicipi() { candidats = new List<Candidat>(); }
        //public PartitMunicipi(string nomPartit, List<Candidat> candidats)
        //{
        //    this.nomPartit = nomPartit;
        //    this.candidats = candidats;
        //}
        public void borrarDatos()
        {
            ID = 0;
            nomPartit= string.Empty;
            candidats.Clear();
        }
        public override string ToString()
        {
            return nomPartit;
        }
    }
}
