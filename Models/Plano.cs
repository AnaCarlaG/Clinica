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
        public Paciente idPaciente { get; set; }
        public List<Paciente> list_paciente { get; set; }
        public Exame idExame { get; set; }
        public List<Exame> list_exame { get; set; }
        public Medico idMedico { get; set; }
        public List<Medico> list_medico { get; set; }

    }
}
