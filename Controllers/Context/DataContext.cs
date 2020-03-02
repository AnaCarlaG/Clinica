using Clinica.Mapper;
using Clinica.Models;
using Microsoft.EntityFrameworkCore;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Controllers.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Atendimento> Atendimento { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<ConsultaPlano> ConsultaPlano { get; set; }
        public DbSet<DiaSemana> DiaSemana { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Exame> Exame { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Plano> Plano { get; set; }
        public DbSet<PreescricaoMedicamento> PreescricaoMedicamentos { get; set; }
        public DbSet<RequisicaoExame> RequisicaoExame { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<ConsultaParticular> ConsultaParticular { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AtendimentoMap(modelBuilder);
            new ConsultaMap(modelBuilder);
            new ConsultaPlanoMap(modelBuilder);
            new ConsultaParticularMap(modelBuilder);
            new DiaSemanaMap(modelBuilder);
            new EnderecoMap(modelBuilder);
            new EspecialidadeMap(modelBuilder);
            new EstadoMap(modelBuilder);
            new ExameMap(modelBuilder);
            new PacienteMap(modelBuilder);
            new PlanoMap(modelBuilder);
            new PreescricaoMedicamentoMap(modelBuilder);
            new RequisicaoExameMap(modelBuilder);
            new MedicoMap(modelBuilder);


            base.OnModelCreating(modelBuilder);
        }    
    }
}
