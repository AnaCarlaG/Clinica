using Sistema.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Medico
    {
        [Key]
        public int idMedico{get;}
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string tel { get; set; }
        public Atendimento atendimento { get; set; }
        public int atendimentoId { get; set; }
        public List<Atendimento> list_atendimento { get; set; }
    }
}
