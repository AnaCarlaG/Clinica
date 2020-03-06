using Clinica.Models;
using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<Endereco>().HasKey(e => e.idEndereco);

            modelBuilder.Entity<Endereco>().Property(e => e.cidade).IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.logradouro).IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.CEP).IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.siglaEstado).IsRequired();
            modelBuilder.Entity<Endereco>().Property(e => e.idEndereco).IsRequired();

            modelBuilder.Entity<Endereco>()
                .HasOne(b => b.Estado)
            .WithMany(c => c.Enderecos).HasForeignKey(p => p.idEndereco);

        }
    }
}
