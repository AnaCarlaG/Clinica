using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class PacienteMap
    {
        public PacienteMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>().Property(p => p.idPaciente).IsRequired();
            modelBuilder.Entity<Paciente>().Property(p => p.nomePaciente).IsRequired();
            modelBuilder.Entity<Paciente>().Property(p => p.sexo).IsRequired();
            modelBuilder.Entity<Paciente>().Property(p => p.dataNascimento).IsRequired();

            modelBuilder.Entity<Paciente>().HasKey(p => p.idPaciente);

            modelBuilder.Entity<Paciente>().HasOne(m => m.Endereco)
                .WithOne().HasForeignKey<Paciente>(m => m.idEndereco);

            modelBuilder.Entity<Paciente>().HasOne(m => m.Plano)
                .WithOne().HasForeignKey<Paciente>(m => m.idPlano);

            modelBuilder.Entity<Paciente>().HasMany(m => m.Consultas)
                .WithOne(c => c.Paciente).HasForeignKey(m => m.idConsulta);

        }
    }
}
