using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Consulta
    {
        [Key]
        public int idConsulta{get;set;}
        public int idPaciente { get; set; }
        public int idPreescricaoMedicamento { get; set; }
        public DateTime dataConsulta { get; set; }
        public ConsultaParticular ConsultaParticular { get; set; }
        public Atendimento Atendimento { get; set; }

        public Paciente Paciente { get; set; }
        public List<PlanoConsulta> PlanoConsultas { get; set; }
        public List<PreescricaoMedicamento> PreescricaoMedicamentos { get; set; }

    }
}
