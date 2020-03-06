using Clinica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Atendimento
    {
        [Key]
        public int idAtendimento { get; }
        public int idMedico { get; }
        public int idConsulta { get; }
        public int idDiaSemana { get; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFim { get; set; }
        public bool atendePlano { get; set; }
        public bool atendeDia { get; set; }

        public Medico Medico { get; }
        public Consulta Consulta { get; }
        public DiaSemana DiaSemana { get; }
    }
}
