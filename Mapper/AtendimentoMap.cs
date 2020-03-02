using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class AtendimentoMap
    {
        public AtendimentoMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atendimento>().HasKey(a => a.idAtendimento);
            modelBuilder.Entity<Atendimento>().HasMany(m => m.list_medico)
                .WithOne(a => a.idAtendimento).HasForeignKey(m => m.idMedico);
            modelBuilder.Entity<Atendimento>().HasOne(a => a.idConsulta)
                .WithOne(c => c.idAtendimento)
                .HasForeignKey<Consulta>(c => c.idAtendimento);
            modelBuilder.Entity<Atendimento>().HasOne(a => a.idDiaSemana)
                .WithOne(d => d.idAtendimento)
                .HasForeignKey<DiaSemana>(d => d.idAtendimento);
        }
    }
}
