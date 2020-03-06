using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class ConsultaParticular
    {        
        public int idConsultaParticular { get; set; }

        public int idConsulta { get; set; }
        public float valor { get; set; }
        public string formaPagamento { get; set; }
        public Consulta Consulta { get; set; }
    }
}
