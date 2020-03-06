using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class ExameReferenciaMap
    {
        public ExameReferenciaMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExameReferencia>().Property(e => e.idExameReferencia).IsRequired();
            modelBuilder.Entity<ExameReferencia>().Property(e => e.sexo).IsRequired();
            modelBuilder.Entity<ExameReferencia>().Property(e => e.idade).IsRequired();
            modelBuilder.Entity<ExameReferencia>().Property(e => e.valor).IsRequired();

            modelBuilder.Entity<ExameReferencia>().HasKey(e => e.idExameReferencia);

            modelBuilder.Entity<ExameReferencia>().HasOne(p => p.Exame)
                .WithMany(p => p.ExameReferencias)
                .HasForeignKey(p => p.idExame);
        }
    }
}
