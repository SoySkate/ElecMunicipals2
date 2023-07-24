using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EleccionsM2.Models;

namespace EleccionsM2.ViewModel
{
    public class ResultatTViewModel
    {
        public ResultatsTaula ResultatTForm { get; set; }
        public ResultatTViewModel()
        {
            ResultatTForm = new ResultatsTaula();
        }
        public void addListaVots(VotsPerLlista vot)
        {
            ResultatTForm.votsLlista.Add(vot);
        }
    }
}
