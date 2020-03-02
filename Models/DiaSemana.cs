using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class DiaSemana
    {
        [Key]
        public int idDiaSemana { get; }
        public string nomeDiaSemana { get; set; }

        public Atendimento atendimento { get; set; }
        public List<Atendimento> list_atendimento { get; set; }
        public int idAtendimento { get; set; }
    }
}
