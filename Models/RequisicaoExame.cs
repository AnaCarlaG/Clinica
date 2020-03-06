using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class RequisicaoExame
    {
        public int idRequisicaoExame { get; set; }
        public DateTime dataRequisicao { get; set; }
        public DateTime dataAgendamento { get; set; }
        public int situacao { get; set; }
    }
}
