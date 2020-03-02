using Microsoft.EntityFrameworkCore;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class EspecialidadeMap
    {
        public EspecialidadeMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Especialidade>().Property(e => e.idEspecialidade).IsRequired();
            modelBuilder.Entity<Especialidade>().Property(e => e.descricaoEspecialidade).IsRequired();

            modelBuilder.Entity<Especialidade>().HasKey(e => e.idEspecialidade);
            modelBuilder.Entity<Especialidade>().HasOne(e => e.idMedico)
                .WithMany(m => m.list_especialidade)
                .HasForeignKey(e => e.idMedico);
        }
    }
}
