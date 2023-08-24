using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.ViewModel
{
    public class ListaCalculEsconsViewModel
    {

        public long ID { get; set; }
        public List<double> escoDividit { get; set; }

        public ListaCalculEsconsViewModel()
        {
            escoDividit = new List<double>();
        }
    }
}
