using System;
using EleccionsM2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.ViewModel
{
    public class PartitViewModel
    {
        public PartitMunicipi PartitForm { get; set; }
        public PartitViewModel() { 
            PartitForm = new PartitMunicipi();
        }
    }
}
