﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Programa.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("DiasParaRetorno")
                        .HasColumnType("int");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Model.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("Model.LocacaoVeiculoLeve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdLocacao")
                        .HasColumnType("int");

                    b.Property<int>("IdVeiculoLeve")
                        .HasColumnType("int");

                    b.Property<int?>("LocacaoId")
                        .HasColumnType("int");

                    b.Property<int?>("VeiculoLeveId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocacaoId");

                    b.HasIndex("VeiculoLeveId");

                    b.ToTable("LocacaoVeiculoLeves");
                });

            modelBuilder.Entity("Model.LocacaoVeiculoPesado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdLocacao")
                        .HasColumnType("int");

                    b.Property<int>("IdVeiculoPesado")
                        .HasColumnType("int");

                    b.Property<int?>("LocacaoId")
                        .HasColumnType("int");

                    b.Property<int?>("VeiculoPesadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocacaoId");

                    b.HasIndex("VeiculoPesadoId");

                    b.ToTable("LocacaoVeiculoPesados");
                });

            modelBuilder.Entity("Model.VeiculoLeve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Marca")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Modelo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("VeiculosLeves");
                });

            modelBuilder.Entity("Model.VeiculoPesado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Modelo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<string>("Restricoes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("VeiculosPesados");
                });

            modelBuilder.Entity("Model.LocacaoVeiculoLeve", b =>
                {
                    b.HasOne("Model.Locacao", "Locacao")
                        .WithMany()
                        .HasForeignKey("LocacaoId");

                    b.HasOne("Model.VeiculoLeve", "VeiculoLeve")
                        .WithMany()
                        .HasForeignKey("VeiculoLeveId");
                });

            modelBuilder.Entity("Model.LocacaoVeiculoPesado", b =>
                {
                    b.HasOne("Model.Locacao", "Locacao")
                        .WithMany()
                        .HasForeignKey("LocacaoId");

                    b.HasOne("Model.VeiculoPesado", "VeiculoPesado")
                        .WithMany()
                        .HasForeignKey("VeiculoPesadoId");
                });
#pragma warning restore 612, 618
        }
    }
}
