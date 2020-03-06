using Clinica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Especialidade
    {
        public int idEspecialidade { get; }
        public string descricaoEspecialidade { get; set; }

        //public int idMedico { get; }

        //public Medico Medico { get; }
    }
}
