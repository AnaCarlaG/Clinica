using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class EstadoMap
    {
        public EstadoMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>().Property(e => e.siglaEstado).IsRequired();
            modelBuilder.Entity<Estado>().Property(e => e.nomeEstado).IsRequired();

            modelBuilder.Entity<Estado>().HasKey(e => e.siglaEstado);
            modelBuilder.Entity<Estado>()
                .HasMany(est => est.Enderecos)
                .WithOne().HasForeignKey(end => end.siglaEstado);


        }
    }
}
