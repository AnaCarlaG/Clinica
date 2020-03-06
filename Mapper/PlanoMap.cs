using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class PlanoMap
    {
        public PlanoMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plano>().Property(p => p.idPlano).IsRequired();
            modelBuilder.Entity<Plano>().Property(p => p.nomePlano).IsRequired();
            modelBuilder.Entity<Plano>().Property(p => p.siglaPlano).IsRequired();

            modelBuilder.Entity<Plano>().HasKey(p => p.idPlano);

            modelBuilder.Entity<Plano>()
                .HasMany(est => est.PlanoConsultas)
                .WithOne().HasForeignKey(end => end.idPlano).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Plano>()
                .HasMany(est => est.Pacientes)
                .WithOne().HasForeignKey(end => end.idPlano);

        }
    }
}
