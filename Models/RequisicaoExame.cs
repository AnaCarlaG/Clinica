using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class RequisicaoExame
    {
        [Key]
        public int idRequisicaoExame { get; set; }
        public DateTime dataRequisicao { get; set; }
        public DateTime dataAgendamentoRequisicaoExame { get; set; }
        public int situacao { get; set; }
        public Exame idExame { get; set; }
        public List<Exame> list_exame { get; set; }
    }
}
