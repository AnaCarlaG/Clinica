﻿using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Mapper
{
    public class ExameReferenciaMap
    {
        public ExameReferenciaMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExameReferencia>().HasKey(e => e.idExameReferencia);
            modelBuilder.Entity<ExameReferencia>().HasOne(e => e.idExame)
                .WithOne(ex=>ex.idExameReferencia)
                .HasForeignKey<ExameReferencia>(e=>e.idExameReferencia);
        }
    }
}