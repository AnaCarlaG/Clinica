using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class EnderecoMap
    {
        public EnderecoMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Endereco>().Property(e => e.cidade).IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.logradouro).IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.CEP).IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.estado).IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.idEndereco).IsRequired();

            modelBuilder.Entity<Endereco>().HasKey(e => e.idEndereco);
            modelBuilder.Entity<Endereco>().HasOne(e => e.idMedico)
                .WithOne(m => m.idEndereco)
                .HasForeignKey<Medico>(m => m.idMedico);
            modelBuilder.Entity<Endereco>().HasOne(end => end.siglaEstado)
                .WithMany(est => est.list_endereco)
                .HasForeignKey(est => est.idEndereco);
            modelBuilder.Entity<Endereco>()
                .HasOne(e => e.idPaciente)
                .WithOne(p => p.idEndereco).HasForeignKey<Endereco>(e => e.idPaciente);

        }
    }
}
