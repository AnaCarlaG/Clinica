using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Especialidade
    {
        [Key]
        public int idEspecialidade { get; }
        public string descricaoEspecialidade { get; set; }
    }
}
