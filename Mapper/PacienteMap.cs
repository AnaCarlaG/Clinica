using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using Sistema.Models;
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
            modelBuilder.Entity<Paciente>().HasOne(p => p.idEndereco)
                .WithOne(e => e.idPaciente)
                .HasForeignKey<Endereco>(e => e.idPaciente);
            modelBuilder.Entity<Paciente>().HasMany(pac => pac.list_plano)
                .WithOne(pla => pla.idPaciente)
                .HasForeignKey(pla =>pla.idPaciente);
        }
    }
}
