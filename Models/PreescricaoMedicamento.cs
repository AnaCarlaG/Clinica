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
        public string medicamentoPreescricaoMedicamento { get; set; }
        public string formaUsoPreescricaoMedicamento  { get; set; }
        public Consulta idConsulta { get; }
        public List<Consulta> list_consulta { get; set; }
    }
}
