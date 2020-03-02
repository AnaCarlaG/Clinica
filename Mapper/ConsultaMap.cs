using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class ConsultaMap
    {
        public ConsultaMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consulta>().HasKey(c => c.idConsulta);
            modelBuilder.Entity<Consulta>().HasOne(c => c.idConsultaPlano)
                .WithOne(con=>con.idConsulta)
                .HasForeignKey<Consulta>(c=>c.idConsultaPlano);
            modelBuilder.Entity<Consulta>().HasOne(c => c.idConsultaParticular)
                .WithOne(c=>c.idConsulta)
                .HasForeignKey<Consulta>(c=>c.idConsultaParticular);
            modelBuilder.Entity<Consulta>().HasOne(c => c.idPreescricaoMedicamento)
                .WithMany(p=>p.list_consulta)
                .HasForeignKey(p=>p.idPreescricaoMedicamento);
            modelBuilder.Entity<Consulta>().HasOne(c => c.idAtendimento)
                .WithOne(a=>a.idConsulta)
                .HasForeignKey<Consulta>(c=>c.idAtendimento);

        }
    }
}
