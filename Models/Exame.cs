using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Exame
    {
        [Key]
        public int idExame { get; set; }
        public string nomeExame { get; set; }
        public string descricaoExame { get; set; }
        public float valorExame { get; set; }
        public Plano plano { get; set; }
        public List<Plano> list_plano { get; set; }
    }
}
