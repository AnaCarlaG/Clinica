using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class PreescricaoMedicamentoMap
    {
        public PreescricaoMedicamentoMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PreescricaoMedicamento>().Property(p => p.idPreescricaoMedicamento).IsRequired();
            modelBuilder.Entity<PreescricaoMedicamento>().Property(p => p.medicamento).IsRequired();
            modelBuilder.Entity<PreescricaoMedicamento>().Property(p => p.formaUso).IsRequired();

            modelBuilder.Entity<PreescricaoMedicamento>().HasKey(p=>p.idPreescricaoMedicamento);
            modelBuilder.Entity<PreescricaoMedicamento>().HasOne(p => p.Consulta)
                .WithMany(p => p.PreescricaoMedicamentos)
                .HasForeignKey(p => p.idConsulta);
        }
    }
}
