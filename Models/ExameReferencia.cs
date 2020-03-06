using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class ExameReferencia
    {
        [Key]
        public int idExameReferencia { get; }
        public int idExame { get; }
        public int sexo { get; set; }
        public int idade { get; set; }
        public float valor { get; set; }
        public Exame Exame { get; set; }
    }
}
