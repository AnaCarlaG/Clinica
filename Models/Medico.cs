using Sistema.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Medico
    {
        [Key]
        public int idMedico { get; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string tel { get; set; }
        public Especialidade idEspecialidade { get; set; }
        public Endereco idEndereco { get; set; }
        public Plano idPlano { get; }
        public Atendimento idAtendimento { get; }
        public List<Plano> list_plano { get; set; } 
        public List<Especialidade> list_especialidade { get; set; }

    }
}
