using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EleccionsM2.Models;
using Microsoft.EntityFrameworkCore;

namespace EleccionsM2
{
    public class EleccionsMContext:DbContext
    {
        public DbSet<Municipi> Municipis { get; set; }
        public DbSet<PartitMunicipi> PartitsPolitics { get; set; }
        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<TaulaElectoral> TaulesElectorals { get; set; }
        public DbSet<ResultatsTaula> ResultatsTaules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //pcAndrew:
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-14D02GT\SQLEXPRESS01;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False; Database=ElecMunicipalsDB");
            //pcPractiques:
            optionsBuilder.UseSqlServer(@"Data Source=FORMACIO1\SQLEXPRESS03;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False; Database=ElecMunicipalsDB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //Comandos para inicializar la Migracion una vez se ha creado o modificado las clases y por lo tanto
        //Se habran modificado las tablas(incluso cambiando de PC)Se modifica parte de las tablas pq la conexion ha cambiado: Comando:::
        //EntityFrameworkCore\Add-Migration (Migration'sName)
        //Después de esto el comando para actualizar la Database es:
        //EntityFrameworkCore\Update-DataBase
    }
}
