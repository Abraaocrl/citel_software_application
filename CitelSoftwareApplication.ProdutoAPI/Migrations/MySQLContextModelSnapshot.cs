﻿// <auto-generated />
using CitelSoftwareApplication.ProdutoAPI.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CitelSoftwareApplication.ProdutoAPI.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CitelSoftwareApplication.ProdutoAPI.Model.Domain.Produto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<long>("CategoriaId")
                        .HasColumnType("bigint")
                        .HasColumnName("categoria_id");

                    b.Property<string>("CategoriaNome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("categoria_nome");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("preco");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
