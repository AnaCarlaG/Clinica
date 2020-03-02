using Microsoft.EntityFrameworkCore;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class DiaSemanaMap
    {
        public DiaSemanaMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiaSemana>().Property(d => d.idDiaSemana).IsRequired();
            modelBuilder.Entity<DiaSemana>().Property(d => d.nomeDiaSemana).IsRequired();
            modelBuilder.Entity<DiaSemana>().HasKey(d => d.idDiaSemana);
            modelBuilder.Entity<DiaSemana>().HasOne(d => d.idAtendimento)
                .WithOne(a => a.idDiaSemana)
                .HasForeignKey<DiaSemana>(a => a.idDiaSemana);
        }
    }
}
