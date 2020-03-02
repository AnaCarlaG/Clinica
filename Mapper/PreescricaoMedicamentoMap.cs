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
            modelBuilder.Entity<PreescricaoMedicamento>().HasKey(p=>p.idPreescricaoMedicamento);
            modelBuilder.Entity<PreescricaoMedicamento>().HasOne(p => p.idConsulta)
                .WithOne(c => c.idPreescricaoMedicamento)
                .HasForeignKey<Consulta>(c=>c.idPreescricaoMedicamento);
        }
    }
}
