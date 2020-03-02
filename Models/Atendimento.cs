using Clinica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Atendimento
    {
        [Key]
        public int idAtendimento { get; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFim { get; set; }
        public bool atendePlano { get; set; }
        public bool atendeDia { get; set; }

        public Medico idMedico { get; }
        public Consulta idConsulta { get; }
        public DiaSemana idDiaSemana { get; }
        public List<Medico> list_medico { get; set; }


    }
}
