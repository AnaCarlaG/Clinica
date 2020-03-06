using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Medico
    {
        public int idMedico { get; }
        public string nome { get; set; }
        public string CRM { get; set; }
        public string tel { get; set; }        
        public Atendimento Atendimento { get; set; }
        public Plano Plano { get; set; }
    }
}
