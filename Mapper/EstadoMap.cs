using Microsoft.EntityFrameworkCore;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class EstadoMap
    {
        public EstadoMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>().HasKey(e => e.siglaEstado);
            modelBuilder.Entity<Estado>()
                .HasMany(est => est.list_endereco)
                .WithOne(end => end.siglaEstado).HasForeignKey(end => end.idEndereco);
        }
    }
}
