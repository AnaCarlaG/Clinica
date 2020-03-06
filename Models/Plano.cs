using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Plano
    {
        [Key]
        public int idPlano { get; }
        public string nomePlano { get; set; }
        public string siglaPlano { get; set; }

        public List<Consulta> Consultas { get; set; }
        public List<PlanoConsulta> PlanoConsultas { get; set; }

        public List<Paciente> Pacientes { get; set; }

    }
}
