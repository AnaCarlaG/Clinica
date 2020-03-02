using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class ConsultaPlanoMap
    {
        public ConsultaPlanoMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConsultaPlano>().Property(c => c.idConsultaPlano).IsRequired();
            modelBuilder.Entity<ConsultaPlano>().Property(c => c.plano).IsRequired();

            modelBuilder.Entity<ConsultaPlano>().HasKey(c=>c.idConsultaPlano);
            modelBuilder.Entity<ConsultaPlano>().HasOne(c => c.idConsulta)
                .WithOne(c => c.idConsultaPlano)
                .HasForeignKey<Consulta>(c => c.idConsultaPlano);
        }
    }
}
