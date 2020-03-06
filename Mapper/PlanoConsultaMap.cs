using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class PlanoConsultaMap
    {
        public PlanoConsultaMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlanoConsulta>().HasKey(p => new { p.idPlano, p.idConsulta });

            modelBuilder.Entity<PlanoConsulta>()
                .HasOne<Consulta>(c => c.Consulta)
                .WithMany(d => d.PlanoConsultas)
                .HasForeignKey(s => s.idConsulta).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlanoConsulta>()
                .HasOne<Plano>(sc => sc.Plano)
                .WithMany(s => s.PlanoConsultas)
                .HasForeignKey(sc => sc.idPlano)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
