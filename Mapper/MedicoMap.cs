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
            modelBuilder.Entity<Medico>().HasKey(m=>m.idMedico);
            modelBuilder.Entity<Medico>().HasOne(a => a.atendimento)
                .WithMany(a => a.list_medico).HasForeignKey(a => a.idMedico);
            modelBuilder.Entity<Atendimento>().HasMany(m => m.list_medico)
                .WithOne(a => a.atendimento).HasForeignKey(m=>m.atendimentoId);
        }
    }
}
