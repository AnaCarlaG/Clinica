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
            modelBuilder.Entity<Consulta>().Property(c => c.idConsulta).IsRequired();
            modelBuilder.Entity<Consulta>().Property(c => c.dataConsulta).IsRequired();

            modelBuilder.Entity<Consulta>().HasKey(c => c.idConsulta);

            modelBuilder.Entity<Consulta>().HasOne(c => c.ConsultaParticular)
                .WithOne(b => b.Consulta)
                .HasForeignKey<ConsultaParticular>(e => e.idConsultaParticular);

            modelBuilder.Entity<Consulta>().HasOne(c => c.Paciente)
                .WithMany(b => b.Consultas)
                .HasForeignKey(e => e.idPaciente);

            modelBuilder.Entity<Consulta>()
                .HasMany(est => est.PlanoConsultas)
                .WithOne().HasForeignKey(end => end.idConsulta);

            modelBuilder.Entity<Consulta>()
                .HasMany(est => est.PreescricaoMedicamentos)
                .WithOne().HasForeignKey(end => end.idPreescricaoMedicamento);
        }
    }
}