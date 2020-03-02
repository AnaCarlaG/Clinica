using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class ConsultaParticularMap
    {
        public ConsultaParticularMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConsultaParticular>().HasKey(c => c.idConsultaParticular);
            modelBuilder.Entity<ConsultaParticular>().HasOne(c => c.idConsulta)
                .WithOne(c => c.idConsultaParticular)
                .HasForeignKey<Consulta>(c=>c.idConsultaParticular);
        }
    }
}
