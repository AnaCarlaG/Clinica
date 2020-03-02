using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class RequisicaoExameMap
    {
        public RequisicaoExameMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequisicaoExame>().Property(r => r.idRequisicaoExame).IsRequired();
            modelBuilder.Entity<RequisicaoExame>().Property(r => r.situacao).IsRequired();
            modelBuilder.Entity<RequisicaoExame>().Property(r => r.dataAgendamento).IsRequired();
            modelBuilder.Entity<RequisicaoExame>().Property(r => r.dataRequisicao).IsRequired();

            modelBuilder.Entity<RequisicaoExame>().HasKey(r=>r.idRequisicaoExame);
            modelBuilder.Entity<RequisicaoExame>().HasMany(r => r.list_exame)
                .WithOne(e => e.idRequisicaoExame)
                .HasForeignKey(r => r.idExame);
        }
    }
}
