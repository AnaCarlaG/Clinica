using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class MedicoMap
    {
        public MedicoMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medico>().Property(m => m.Nome).IsRequired();
            modelBuilder.Entity<Medico>().Property(m => m.CRM).IsRequired();
            modelBuilder.Entity<Medico>().Property(m => m.tel).IsRequired();
            modelBuilder.Entity<Medico>().Property(m => m.idMedico).IsRequired();

            modelBuilder.Entity<Medico>().HasKey(m => m.idMedico);
            modelBuilder.Entity<Medico>().HasOne(a => a.idAtendimento)
                .WithMany(m => m.list_medico)
                .HasForeignKey(a => a.idMedico);
            modelBuilder.Entity<Medico>().HasOne(m => m.idEndereco)
                .WithOne(e => e.idMedico)
                .HasForeignKey<Endereco>(e => e.idMedico);
            modelBuilder.Entity<Medico>()
                .HasMany(m => m.list_especialidade)
                .WithOne(e => e.idMedico).HasForeignKey(m => m.idMedico);
            modelBuilder.Entity<Medico>().HasMany(m => m.list_plano)
                .WithOne(p => p.idMedico)
                .HasForeignKey(p => p.idMedico);
        }
    }
}
