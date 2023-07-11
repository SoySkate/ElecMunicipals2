using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.Models
{
    public class Candidat
    {
        public long ID { get; set; }
        public string nomCandidat { get; set; }
        public Candidat() { }
        //public Candidat(string nomCandidat)
        //{
        //    this.nomCandidat = nomCandidat;
        //}
        public string ImprimirCandidat()
        {
            return nomCandidat;
        }
        public void borrarDatos()
        {
            ID = 0;
            nomCandidat= string.Empty;
        }
    }
}
