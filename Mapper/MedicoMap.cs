using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class MedicoMap
    {
        public MedicoMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medico>().Property(m => m.nome).IsRequired();
            modelBuilder.Entity<Medico>().Property(m => m.CRM).IsRequired();
            modelBuilder.Entity<Medico>().Property(m => m.tel).IsRequired();
            modelBuilder.Entity<Medico>().Property(m => m.idMedico).IsRequired();

            modelBuilder.Entity<Medico>().HasKey(m => m.idMedico);

        }
    }
}
