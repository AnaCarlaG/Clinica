using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class PreescricaoMedicamento
    {   
        [Key]
        public int idPreescricaoMedicamento { get; set; }
        public int idConsulta { get; set; }
        public string medicamento{ get; set; }
        public string formaUso  { get; set; }
        public Consulta Consulta { get; set; }
    }
}
