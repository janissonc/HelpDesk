using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpDesk.Migrations
{
    public partial class InitialMigrationDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Priooridades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeEdicao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priooridades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDeEquipamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeEquipamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secretaria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Setor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patrimonio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDeSerie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeloEquipamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Configuracoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etiqueta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PessoaId = table.Column<int>(type: "int", nullable: true),
                    DeletarTarefa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriarTarefa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditarTarefa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatorioDeTarefa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletarUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditarUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriarUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriarRecurso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditarRecurso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletarRecurso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriarIncidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditarIncidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletarIncidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancelarIncidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Pessoas_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    Problema = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Secretaria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDePatrimonio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadeId = table.Column<int>(type: "int", nullable: true),
                    DataDeAbertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeFechamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuantidadeDeHorasGastas = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidentes_Priooridades_PrioridadeId",
                        column: x => x.PrioridadeId,
                        principalTable: "Priooridades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidentes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Incidentes_PrioridadeId",
                table: "Incidentes",
                column: "PrioridadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidentes_UsuarioId",
                table: "Incidentes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PessoaId",
                table: "Usuarios",
                column: "PessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidentes");

            migrationBuilder.DropTable(
                name: "Recursos");

            migrationBuilder.DropTable(
                name: "Priooridades");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
