using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EleccionsM2.ViewModel
{
    public class RegidorsViewModel
    {
        public long ID { get; set; }
        public string nomCandiat { get; set; }
        public string nomPartit { get; set; }

        public RegidorsViewModel() { }
    }
}
