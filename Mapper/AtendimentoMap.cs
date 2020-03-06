using Clinica.Models;
using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<Atendimento>().Property(a => a.horaInicio).IsRequired();
            modelBuilder.Entity<Atendimento>().Property(a => a.horaFim).IsRequired();
            modelBuilder.Entity<Atendimento>().Property(a => a.atendeDia).IsRequired();
            modelBuilder.Entity<Atendimento>().Property(a => a.atendePlano).IsRequired();

            modelBuilder.Entity<Atendimento>().HasOne(m => m.Medico)
                .WithOne(a => a.Atendimento).HasForeignKey<Atendimento>(m => m.idMedico);

            modelBuilder.Entity<Atendimento>().HasOne(m => m.Consulta)
                .WithOne(a => a.Atendimento).HasForeignKey<Atendimento>(m => m.idConsulta);

            modelBuilder.Entity<Atendimento>().HasOne(a => a.DiaSemana)
                .WithOne(d => d.Atendimento)
                .HasForeignKey<DiaSemana>(d => d.idDiaSemana);
        }
    }
}
