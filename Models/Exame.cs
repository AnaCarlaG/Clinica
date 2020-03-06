using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Exame
    {
        public int idExame { get; set; }
        public string nomeExame { get; set; }
        public string descricaoExame { get; set; }
        public float valorExame { get; set; } 
        public List<ExameReferencia> ExameReferencias { get; set; }

    }
}
