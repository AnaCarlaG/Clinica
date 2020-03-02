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
        public DateTime horario { get; set; }
        public DateTime horaFim { get; set; }
        public bool atendePlano { get; set; }
        public bool atendeDia { get; set; }
        public Consulta consultaId { get; }
        public Especialidade especialidade { get; set; }
        public List<Especialidade> list_especialidade { get; set; }
        public Medico medico { get; set; }
        public List<Medico> list_medico { get; set; }
        public DiaSemana diaSemanaId { get; set; }
    }
}
