using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EleccionsM2.Models;

namespace EleccionsM2.ViewModel
{
    public class VotsTotalsViewModel
    {
        public ResultatsTaula VotsTotalsResultatForm { get; set; }
        public VotsTotalsViewModel()
        {
            VotsTotalsResultatForm = new ResultatsTaula();
        }
    }
}
