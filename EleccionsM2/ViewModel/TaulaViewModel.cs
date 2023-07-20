using System;
using EleccionsM2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.ViewModel
{
    public class TaulaViewModel
    {
        public TaulaElectoral TaulaForm { get; set; }
        public TaulaViewModel()
        {
            TaulaForm = new TaulaElectoral();
        }
    }
}
