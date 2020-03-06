﻿// <auto-generated />
using System;
using Clinica.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clinica.Migrations
{
    [DbContext(typeof(ClinicaContext))]
    partial class ClinicaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clinica.Models.Atendimento", b =>
                {
                    b.Property<int>("idAtendimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("atendeDia")
                        .HasColumnType("bit");

                    b.Property<bool>("atendePlano")
                        .HasColumnType("bit");

                    b.Property<DateTime>("horaFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("horaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("idConsulta")
                        .HasColumnType("int");

                    b.Property<int>("idMedico")
                        .HasColumnType("int");

                    b.HasKey("idAtendimento");

                    b.HasIndex("idConsulta")
                        .IsUnique();

                    b.HasIndex("idMedico")
                        .IsUnique();

                    b.ToTable("Atendimento");
                });

            modelBuilder.Entity("Clinica.Models.Consulta", b =>
                {
                    b.Property<int>("idConsulta")
                        .HasColumnType("int");

                    b.Property<int?>("PlanoidPlano")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataConsulta")
                        .HasColumnType("datetime2");

                    b.Property<int>("idPaciente")
                        .HasColumnType("int");

                    b.Property<int>("idPreescricaoMedicamento")
                        .HasColumnType("int");

                    b.HasKey("idConsulta");

                    b.HasIndex("PlanoidPlano");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("Clinica.Models.ConsultaParticular", b =>
                {
                    b.Property<int>("idConsultaParticular")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("formaPagamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idConsulta")
                        .HasColumnType("int");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("idConsultaParticular");

                    b.ToTable("ConsultaParticular");
                });

            modelBuilder.Entity("Clinica.Models.DiaSemana", b =>
                {
                    b.Property<int>("idDiaSemana")
                        .HasColumnType("int");

                    b.Property<string>("nomeDiaSemana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idDiaSemana");

                    b.ToTable("DiaSemana");
                });

            modelBuilder.Entity("Clinica.Models.Endereco", b =>
                {
                    b.Property<int>("idEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadosiglaEstado")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("siglaEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("idEndereco");

                    b.HasIndex("EstadosiglaEstado");

                    b.HasIndex("siglaEstado");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Clinica.Models.Especialidade", b =>
                {
                    b.Property<int>("idEspecialidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricaoEspecialidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEspecialidade");

                    b.ToTable("Especialidade");
                });

            modelBuilder.Entity("Clinica.Models.Estado", b =>
                {
                    b.Property<string>("siglaEstado")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("nomeEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("siglaEstado");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("Clinica.Models.Exame", b =>
                {
                    b.Property<int>("idExame")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricaoExame")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomeExame")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("valorExame")
                        .HasColumnType("real");

                    b.HasKey("idExame");

                    b.ToTable("Exame");
                });

            modelBuilder.Entity("Clinica.Models.ExameReferencia", b =>
                {
                    b.Property<int>("idExameReferencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idExame")
                        .HasColumnType("int");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<int>("sexo")
                        .HasColumnType("int");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("idExameReferencia");

                    b.HasIndex("idExame");

                    b.ToTable("ExameReferencia");
                });

            modelBuilder.Entity("Clinica.Models.Medico", b =>
                {
                    b.Property<int>("idMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlanoidPlano")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMedico");

                    b.HasIndex("PlanoidPlano");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("Clinica.Models.Paciente", b =>
                {
                    b.Property<int>("idPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PlanoidPlano")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("idEndereco")
                        .HasColumnType("int");

                    b.Property<int>("idPlano")
                        .HasColumnType("int");

                    b.Property<string>("nomePaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sexo")
                        .HasColumnType("int");

                    b.HasKey("idPaciente");

                    b.HasIndex("PlanoidPlano");

                    b.HasIndex("idEndereco")
                        .IsUnique();

                    b.HasIndex("idPlano");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("Clinica.Models.Plano", b =>
                {
                    b.Property<int>("idPlano")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nomePlano")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("siglaPlano")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPlano");

                    b.ToTable("Plano");
                });

            modelBuilder.Entity("Clinica.Models.PlanoConsulta", b =>
                {
                    b.Property<int>("idPlano")
                        .HasColumnType("int");

                    b.Property<int>("idConsulta")
                        .HasColumnType("int");

                    b.HasKey("idPlano", "idConsulta");

                    b.HasIndex("idConsulta");

                    b.ToTable("PlanoConsulta");
                });

            modelBuilder.Entity("Clinica.Models.PreescricaoMedicamento", b =>
                {
                    b.Property<int>("idPreescricaoMedicamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("formaUso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idConsulta")
                        .HasColumnType("int");

                    b.Property<string>("medicamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPreescricaoMedicamento");

                    b.HasIndex("idConsulta");

                    b.ToTable("PreescricaoMedicamentos");
                });

            modelBuilder.Entity("Clinica.Models.RequisicaoExame", b =>
                {
                    b.Property<int>("idRequisicaoExame")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("dataAgendamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dataRequisicao")
                        .HasColumnType("datetime2");

                    b.Property<int>("situacao")
                        .HasColumnType("int");

                    b.HasKey("idRequisicaoExame");

                    b.ToTable("RequisicaoExame");
                });

            modelBuilder.Entity("Clinica.Models.Atendimento", b =>
                {
                    b.HasOne("Clinica.Models.Consulta", "Consulta")
                        .WithOne("Atendimento")
                        .HasForeignKey("Clinica.Models.Atendimento", "idConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinica.Models.Medico", "Medico")
                        .WithOne("Atendimento")
                        .HasForeignKey("Clinica.Models.Atendimento", "idMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinica.Models.Consulta", b =>
                {
                    b.HasOne("Clinica.Models.Plano", null)
                        .WithMany("Consultas")
                        .HasForeignKey("PlanoidPlano");

                    b.HasOne("Clinica.Models.ConsultaParticular", "ConsultaParticular")
                        .WithOne("Consulta")
                        .HasForeignKey("Clinica.Models.Consulta", "idConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinica.Models.Paciente", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("idConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinica.Models.DiaSemana", b =>
                {
                    b.HasOne("Clinica.Models.Atendimento", "Atendimento")
                        .WithOne("DiaSemana")
                        .HasForeignKey("Clinica.Models.DiaSemana", "idDiaSemana")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinica.Models.Endereco", b =>
                {
                    b.HasOne("Clinica.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadosiglaEstado");

                    b.HasOne("Clinica.Models.Estado", null)
                        .WithMany("Enderecos")
                        .HasForeignKey("siglaEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinica.Models.ExameReferencia", b =>
                {
                    b.HasOne("Clinica.Models.Exame", "Exame")
                        .WithMany("ExameReferencias")
                        .HasForeignKey("idExame")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinica.Models.Medico", b =>
                {
                    b.HasOne("Clinica.Models.Plano", "Plano")
                        .WithMany()
                        .HasForeignKey("PlanoidPlano");
                });

            modelBuilder.Entity("Clinica.Models.Paciente", b =>
                {
                    b.HasOne("Clinica.Models.Plano", "Plano")
                        .WithMany()
                        .HasForeignKey("PlanoidPlano");

                    b.HasOne("Clinica.Models.Endereco", "Endereco")
                        .WithOne()
                        .HasForeignKey("Clinica.Models.Paciente", "idEndereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinica.Models.Plano", null)
                        .WithMany("Pacientes")
                        .HasForeignKey("idPlano")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinica.Models.PlanoConsulta", b =>
                {
                    b.HasOne("Clinica.Models.Consulta", "Consulta")
                        .WithMany("PlanoConsultas")
                        .HasForeignKey("idConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clinica.Models.Plano", "Plano")
                        .WithMany("PlanoConsultas")
                        .HasForeignKey("idPlano")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Clinica.Models.PreescricaoMedicamento", b =>
                {
                    b.HasOne("Clinica.Models.Consulta", "Consulta")
                        .WithMany("PreescricaoMedicamentos")
                        .HasForeignKey("idConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
