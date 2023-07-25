using EleccionsM2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.ViewModel
{
    public class ResultatsViewModel
    {
        EleccionsMContext Rcontext;
        public List<Municipi> ListaMunicipis { get; set; }

        public ResultatsViewModel() {
            //posar el context a la listMunicipis
            
        }
    }
}
