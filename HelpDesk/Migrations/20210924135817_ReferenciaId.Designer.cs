﻿// <auto-generated />
using System;
using HelpDesk.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HelpDesk.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210924135817_ReferenciaId")]
    partial class ReferenciaId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HelpDesk.Models.Incidente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDeAbertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeFechamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDePatrimonio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PrioridadeId")
                        .HasColumnType("int");

                    b.Property<string>("Problema")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("QuantidadeDeHorasGastas")
                        .HasColumnType("float");

                    b.Property<string>("Secretaria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrioridadeId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Incidentes");
                });

            modelBuilder.Entity("HelpDesk.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Matricula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("HelpDesk.Models.Prioridade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataDeCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDeEdicao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Priooridades");
                });

            modelBuilder.Entity("HelpDesk.Models.Recurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Configuracoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Etiqueta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModeloEquipamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEquipamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDeSerie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patrimonio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Secretaria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Setor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDeEquipamento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recursos");
                });

            modelBuilder.Entity("HelpDesk.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CancelarIncidente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CriarIncidente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CriarRecurso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CriarTarefa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CriarUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeletarIncidente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeletarRecurso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeletarTarefa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeletarUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EditarIncidente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EditarRecurso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EditarTarefa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EditarUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<string>("RelatorioDeTarefa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("HelpDesk.Models.Incidente", b =>
                {
                    b.HasOne("HelpDesk.Models.Prioridade", "Prioridade")
                        .WithMany()
                        .HasForeignKey("PrioridadeId");

                    b.HasOne("HelpDesk.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prioridade");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("HelpDesk.Models.Usuario", b =>
                {
                    b.HasOne("HelpDesk.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
