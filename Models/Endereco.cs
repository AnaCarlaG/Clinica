using Clinica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Endereco
    {
        [Key]
        public int idEndereco { get; set; }
        public string cidade { get; set; }
        public string logradouro { get; set; }
        public string CEP { get; set; }
        public Estado Estado { get; set; }
        public string siglaEstado { get; set; }
    }
}
