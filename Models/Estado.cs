﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Estado
    {
        [Key]
        public string siglaEstado { get; set; }
        public string nomeEstado { get; set; }
        
        public List<Endereco> Enderecos { get; set; }
    }
}
