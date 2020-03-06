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
            modelBuilder.Entity<Exame>().HasKey(e => e.idExame);

            modelBuilder.Entity<Exame>().Property(e => e.idExame).IsRequired();
            modelBuilder.Entity<Exame>().Property(e => e.nomeExame).IsRequired();
            modelBuilder.Entity<Exame>().Property(e => e.descricaoExame).IsRequired();
            modelBuilder.Entity<Exame>().Property(e => e.valorExame).IsRequired();
        }
    }
}
