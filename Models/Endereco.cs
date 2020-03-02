using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Endereco
    {
        [Key]
        public int idEndereco { get; set; }
        public string cidade { get; set; }
        public string logradouro { get; set; }
        public string CEP { get; set; }
    }
}
