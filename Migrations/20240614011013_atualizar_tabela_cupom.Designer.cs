﻿// <auto-generated />
using System;
using CupomDesconto.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CupomDesconto.Migrations
{
    [DbContext(typeof(CupomDescontoContext))]
    [Migration("20240614011013_atualizar_tabela_cupom")]
    partial class atualizar_tabela_cupom
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CupomDesconto.Models.Cupom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("DataValidade")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("LojaID")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Percentual_Desconto")
                        .HasColumnType("numeric");

                    b.Property<int>("ProdutoID")
                        .HasColumnType("integer");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("integer");

                    b.Property<decimal?>("Valor_Desconto")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("LojaID");

                    b.HasIndex("ProdutoID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Cupom");
                });

            modelBuilder.Entity("CupomDesconto.Models.Loja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Loja");
                });

            modelBuilder.Entity("CupomDesconto.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("Preco")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("CupomDesconto.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("CupomDesconto.Models.Cupom", b =>
                {
                    b.HasOne("CupomDesconto.Models.Loja", "Loja")
                        .WithMany()
                        .HasForeignKey("LojaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CupomDesconto.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CupomDesconto.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Loja");

                    b.Navigation("Produto");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
