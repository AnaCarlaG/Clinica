using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class ExameMap
    {
        public ExameMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exame>().HasKey(ex => ex.idExame);
            modelBuilder.Entity<Exame>().HasMany(ex => ex.list_plano)
                .WithOne(p => p.idExame)
                .HasForeignKey(ex => ex.idPlano);
            modelBuilder.Entity<Exame>().HasOne(ex => ex.idExameReferencia)
                .WithOne(e => e.idExame)
                .HasForeignKey<ExameReferencia>(e=>e.idExame);
            modelBuilder.Entity<Exame>().HasMany(ex => ex.list_requisicaoExame)
                .WithOne(e => e.idExame)
                .HasForeignKey(ex=>ex.idExame);
        }
    }
}
