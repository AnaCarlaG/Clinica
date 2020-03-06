using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinica.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsultaParticular",
                columns: table => new
                {
                    idConsultaParticular = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idConsulta = table.Column<int>(nullable: false),
                    valor = table.Column<float>(nullable: false),
                    formaPagamento = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultaParticular", x => x.idConsultaParticular);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    idEspecialidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricaoEspecialidade = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.idEspecialidade);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    siglaEstado = table.Column<string>(nullable: false),
                    nomeEstado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.siglaEstado);
                });

            migrationBuilder.CreateTable(
                name: "Exame",
                columns: table => new
                {
                    idExame = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeExame = table.Column<string>(nullable: false),
                    descricaoExame = table.Column<string>(nullable: false),
                    valorExame = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exame", x => x.idExame);
                });

            migrationBuilder.CreateTable(
                name: "Plano",
                columns: table => new
                {
                    idPlano = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomePlano = table.Column<string>(nullable: false),
                    siglaPlano = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plano", x => x.idPlano);
                });

            migrationBuilder.CreateTable(
                name: "RequisicaoExame",
                columns: table => new
                {
                    idRequisicaoExame = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataRequisicao = table.Column<DateTime>(nullable: false),
                    dataAgendamento = table.Column<DateTime>(nullable: false),
                    situacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequisicaoExame", x => x.idRequisicaoExame);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    idEndereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cidade = table.Column<string>(nullable: false),
                    logradouro = table.Column<string>(nullable: false),
                    CEP = table.Column<string>(nullable: false),
                    EstadosiglaEstado = table.Column<string>(nullable: true),
                    siglaEstado = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.idEndereco);
                    table.ForeignKey(
                        name: "FK_Endereco_Estado_EstadosiglaEstado",
                        column: x => x.EstadosiglaEstado,
                        principalTable: "Estado",
                        principalColumn: "siglaEstado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Endereco_Estado_siglaEstado",
                        column: x => x.siglaEstado,
                        principalTable: "Estado",
                        principalColumn: "siglaEstado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExameReferencia",
                columns: table => new
                {
                    idExameReferencia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idExame = table.Column<int>(nullable: false),
                    sexo = table.Column<int>(nullable: false),
                    idade = table.Column<int>(nullable: false),
                    valor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExameReferencia", x => x.idExameReferencia);
                    table.ForeignKey(
                        name: "FK_ExameReferencia_Exame_idExame",
                        column: x => x.idExame,
                        principalTable: "Exame",
                        principalColumn: "idExame",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    idMedico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(nullable: false),
                    CRM = table.Column<string>(nullable: false),
                    tel = table.Column<string>(nullable: false),
                    PlanoidPlano = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.idMedico);
                    table.ForeignKey(
                        name: "FK_Medico_Plano_PlanoidPlano",
                        column: x => x.PlanoidPlano,
                        principalTable: "Plano",
                        principalColumn: "idPlano",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    idPaciente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idEndereco = table.Column<int>(nullable: false),
                    idPlano = table.Column<int>(nullable: false),
                    nomePaciente = table.Column<string>(nullable: false),
                    sexo = table.Column<int>(nullable: false),
                    dataNascimento = table.Column<DateTime>(nullable: false),
                    PlanoidPlano = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.idPaciente);
                    table.ForeignKey(
                        name: "FK_Paciente_Plano_PlanoidPlano",
                        column: x => x.PlanoidPlano,
                        principalTable: "Plano",
                        principalColumn: "idPlano",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Paciente_Endereco_idEndereco",
                        column: x => x.idEndereco,
                        principalTable: "Endereco",
                        principalColumn: "idEndereco",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paciente_Plano_idPlano",
                        column: x => x.idPlano,
                        principalTable: "Plano",
                        principalColumn: "idPlano",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    idConsulta = table.Column<int>(nullable: false),
                    idPaciente = table.Column<int>(nullable: false),
                    idPreescricaoMedicamento = table.Column<int>(nullable: false),
                    dataConsulta = table.Column<DateTime>(nullable: false),
                    PlanoidPlano = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.idConsulta);
                    table.ForeignKey(
                        name: "FK_Consulta_Plano_PlanoidPlano",
                        column: x => x.PlanoidPlano,
                        principalTable: "Plano",
                        principalColumn: "idPlano",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consulta_ConsultaParticular_idConsulta",
                        column: x => x.idConsulta,
                        principalTable: "ConsultaParticular",
                        principalColumn: "idConsultaParticular",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consulta_Paciente_idConsulta",
                        column: x => x.idConsulta,
                        principalTable: "Paciente",
                        principalColumn: "idPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    idAtendimento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idMedico = table.Column<int>(nullable: false),
                    idConsulta = table.Column<int>(nullable: false),
                    horaInicio = table.Column<DateTime>(nullable: false),
                    horaFim = table.Column<DateTime>(nullable: false),
                    atendePlano = table.Column<bool>(nullable: false),
                    atendeDia = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.idAtendimento);
                    table.ForeignKey(
                        name: "FK_Atendimento_Consulta_idConsulta",
                        column: x => x.idConsulta,
                        principalTable: "Consulta",
                        principalColumn: "idConsulta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atendimento_Medico_idMedico",
                        column: x => x.idMedico,
                        principalTable: "Medico",
                        principalColumn: "idMedico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanoConsulta",
                columns: table => new
                {
                    idPlano = table.Column<int>(nullable: false),
                    idConsulta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoConsulta", x => new { x.idPlano, x.idConsulta });
                    table.ForeignKey(
                        name: "FK_PlanoConsulta_Consulta_idConsulta",
                        column: x => x.idConsulta,
                        principalTable: "Consulta",
                        principalColumn: "idConsulta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanoConsulta_Plano_idPlano",
                        column: x => x.idPlano,
                        principalTable: "Plano",
                        principalColumn: "idPlano");
                });

            migrationBuilder.CreateTable(
                name: "PreescricaoMedicamentos",
                columns: table => new
                {
                    idPreescricaoMedicamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idConsulta = table.Column<int>(nullable: false),
                    medicamento = table.Column<string>(nullable: false),
                    formaUso = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreescricaoMedicamentos", x => x.idPreescricaoMedicamento);
                    table.ForeignKey(
                        name: "FK_PreescricaoMedicamentos_Consulta_idConsulta",
                        column: x => x.idConsulta,
                        principalTable: "Consulta",
                        principalColumn: "idConsulta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiaSemana",
                columns: table => new
                {
                    idDiaSemana = table.Column<int>(nullable: false),
                    nomeDiaSemana = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaSemana", x => x.idDiaSemana);
                    table.ForeignKey(
                        name: "FK_DiaSemana_Atendimento_idDiaSemana",
                        column: x => x.idDiaSemana,
                        principalTable: "Atendimento",
                        principalColumn: "idAtendimento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_idConsulta",
                table: "Atendimento",
                column: "idConsulta",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_idMedico",
                table: "Atendimento",
                column: "idMedico",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_PlanoidPlano",
                table: "Consulta",
                column: "PlanoidPlano");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_EstadosiglaEstado",
                table: "Endereco",
                column: "EstadosiglaEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_siglaEstado",
                table: "Endereco",
                column: "siglaEstado");

            migrationBuilder.CreateIndex(
                name: "IX_ExameReferencia_idExame",
                table: "ExameReferencia",
                column: "idExame");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_PlanoidPlano",
                table: "Medico",
                column: "PlanoidPlano");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_PlanoidPlano",
                table: "Paciente",
                column: "PlanoidPlano");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_idEndereco",
                table: "Paciente",
                column: "idEndereco",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_idPlano",
                table: "Paciente",
                column: "idPlano");

            migrationBuilder.CreateIndex(
                name: "IX_PlanoConsulta_idConsulta",
                table: "PlanoConsulta",
                column: "idConsulta");

            migrationBuilder.CreateIndex(
                name: "IX_PreescricaoMedicamentos_idConsulta",
                table: "PreescricaoMedicamentos",
                column: "idConsulta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaSemana");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "ExameReferencia");

            migrationBuilder.DropTable(
                name: "PlanoConsulta");

            migrationBuilder.DropTable(
                name: "PreescricaoMedicamentos");

            migrationBuilder.DropTable(
                name: "RequisicaoExame");

            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Exame");

            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "ConsultaParticular");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Plano");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
