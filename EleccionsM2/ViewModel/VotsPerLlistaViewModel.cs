using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EleccionsM2.Models;

namespace EleccionsM2.ViewModel
{
    public class VotsPerLlistaViewModel
    {
        public VotsPerLlista VotsPerLlistaForm { get; set; }
        public VotsPerLlistaViewModel()
        {
            VotsPerLlistaForm = new VotsPerLlista();
        }
    }
}
