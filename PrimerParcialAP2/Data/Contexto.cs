using Microsoft.EntityFrameworkCore;
using PrimerParcialAP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialAP2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Registros> registros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

                                        
            optionsBuilder.UseSqlServer(@"Server=.\SqlExpress; Database=ProductosPDb; Trusted_Connection= True");
        }




    }
}
