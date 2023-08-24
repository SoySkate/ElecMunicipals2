using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.ViewModel
{
    public class TaulaDadesViewModel
    {
        public long ID { get; set; }
        public int VotsBlancs { get; set; }
        public int VotsTotals { get; set; } 
        public int VotsNuls { get; set; }
        public int VotsEscrotats { get; set; }
        public double Escrotat { get; set; }
        public double Participació { get; set; }    

        public TaulaDadesViewModel() { }
        
    }
}
