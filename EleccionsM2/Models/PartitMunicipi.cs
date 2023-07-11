using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleccionsM2.Models
{
    public class PartitMunicipi
    {
        public long ID { get; set; }
        public string nomPartit { get; set; }
        public List<Candidat> candidats { get; set; }
        //Poner el municipio aqui creo que no porque al crear el onjeto este debo crear otro municipio y no tiene sentido...
        //CREAR QUE NO NECESITO EL MUNICIPI AQUI
        //public Municipi municipi { get; set; }  
        public PartitMunicipi() { candidats = new List<Candidat>(); }
        //public PartitMunicipi(string nomPartit, List<Candidat> candidats)
        //{
        //    this.nomPartit = nomPartit;
        //    this.candidats = candidats;
        //}
        public string imprimirPartit()
        {
            return nomPartit;
        }
        public void borrarDatos()
        {
            ID = 0;
            nomPartit= string.Empty;
            candidats.Clear();
        }
    }
}
