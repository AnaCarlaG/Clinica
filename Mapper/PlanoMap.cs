using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class PlanoMap
    {
        public PlanoMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plano>().HasKey(p => p.idPlano);
        }
    }
}
