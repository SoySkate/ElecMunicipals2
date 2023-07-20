using EleccionsM2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.ViewModel
{
    public class CandidatViewModel
    {
        public Candidat CandidatForm { get; set; }
        public CandidatViewModel() {
            CandidatForm = new Candidat();
        }
    }
}
