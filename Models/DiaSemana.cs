using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class DiaSemana
    {
        [Key]
        public int idDiaSemana { get; }
        public string nomeDiaSemana { get; set; }
        public Atendimento Atendimento { get; set; }

    }
}
