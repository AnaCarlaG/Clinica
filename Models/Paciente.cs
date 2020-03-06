using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Paciente
    {
        [Key]
        public int idPaciente { get; }
        public int idEndereco { get; }
        public int idPlano { get; }
        public string nomePaciente { get; set; }
        public int sexo { get; set; }
        public DateTime dataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public Plano Plano { get; set; }
        public List<Consulta> Consultas { get; set; }
    }
}
