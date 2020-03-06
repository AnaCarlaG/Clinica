using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class PlanoConsulta
    {
        [Key]
        public int idPlanoConsulta { get; }
        public int idPlano { get; }
        public int idConsulta { get; }
        public Consulta Consulta { get; set; }
        public Plano Plano { get; set; }

    }
}
