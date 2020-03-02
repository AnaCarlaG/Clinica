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
            modelBuilder.Entity<Plano>().HasMany(pla => pla.list_paciente)
                .WithOne(pac => pac.idPlano)
                .HasForeignKey(pac => pac.idPlano);
            modelBuilder.Entity<Plano>().HasMany(p => p.list_exame)
                .WithOne(e => e.idPlano)
                .HasForeignKey(e => e.idPlano);
            modelBuilder.Entity<Plano>().HasMany(p => p.list_medico)
                .WithOne(m => m.idPlano)
                .HasForeignKey(m => m.idPlano);
        }
    }
}
