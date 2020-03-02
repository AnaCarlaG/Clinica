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
            modelBuilder.Entity<Atendimento>().HasOne(a => a.consultaId)
                .WithOne(c => c.atendimento);
            modelBuilder.Entity<Atendimento>().HasMany(m => m.list_medico)
                .WithOne(a => a.atendimento).HasForeignKey(m=>m.atendimentoId);
        }
    }
}
