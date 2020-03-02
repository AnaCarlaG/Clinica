using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class ConsultaPlano
    {
        [Key]
        public int idConsultaPlano { get; }
        public Plano plano { get; set; }
        public Plano idPlano { get; set; }
        public List<Plano> list_planos { get; set; }
        public Consulta idConsulta { get; }
    }
}
