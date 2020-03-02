using Microsoft.EntityFrameworkCore;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Models
{
    public class Consulta
    {
        [Key]
        public long idConsulta{get;set;}
        public DateTime dataConsulta { get; set; }
        public ConsultaParticular consultaParticular { get; set; }
        public ConsultaPlano consultaPlano { get; set; }
        public List<ConsultaPlano> list_consultaPlanos { get; set; }
        public List<ConsultaParticular> list_consultaParticular { get; set; }
        public PreescricaoMedicamento preescricaoMedicamento { get; set; }
        public List<PreescricaoMedicamento> list_preescricaomedica { get; set; }
        public Atendimento idAtendimento { get; set; }
        public Atendimento atendimento { get; set; }
    }

}
