﻿using Sistema.Models;
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
        public string nomePaciente { get; set; }
        public int sexo { get; set; }
        public DateTime dataNascimento { get; set; }
        public Estado estado { get; set; }
        public Consulta consulta { get; set; }
        public List<Consulta> list_consulta { get; set; }
        public Endereco endereco { get; set; }
    }
}