using System;
using EleccionsM2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.ViewModel
{
    public class MunicipiViewModel
    {
        public Municipi MunicipiForm { get; set; }

        public  MunicipiViewModel()
        {
            MunicipiForm = new Municipi();
        }

    }
}
