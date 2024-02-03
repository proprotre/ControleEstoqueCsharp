﻿// <auto-generated />
using Controle_de_Estoque_CSharp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Controle_de_Estoque_CSharp.Migrations
{
    [DbContext(typeof(ControleEstoque))]
    partial class ControleEstoqueModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Controle_de_Estoque_CSharp.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ValorCompra")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("TEXT");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
