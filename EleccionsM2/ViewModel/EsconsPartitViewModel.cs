using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.ViewModel
{
    public class EsconsPartitViewModel
    {
        public long ID { get; set; }
        public string nomPartit { get; set; }
        public int numeroVots { get; set; } 
        public int escons { get; set; }
        public double pVots { get; set; }
        public EsconsPartitViewModel()
        {

        }
    }
}
