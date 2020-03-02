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
            modelBuilder.Entity<DiaSemana>().HasKey(d =>d.idDiaSemana);
            modelBuilder.Entity<DiaSemana>().HasMany(a => a.list_atendimento)
                .WithOne(a => a.diaSemanaId).HasForeignKey(a=>a.idAtendimento);
        }
    }
}
