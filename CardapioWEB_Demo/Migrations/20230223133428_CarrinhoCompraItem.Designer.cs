﻿// <auto-generated />
using CardapioWEB_Demo.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CardapioWEB_Demo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230223133428_CarrinhoCompraItem")]
    partial class CarrinhoCompraItem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CardapioWEB_Demo.Models.CarrinhoCompraItem", b =>
                {
                    b.Property<int>("CarrinhoCompraItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarrinhoCompraItemId"));

                    b.Property<string>("CarrinhoCompraId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("lancheID")
                        .HasColumnType("int");

                    b.HasKey("CarrinhoCompraItemId");

                    b.HasIndex("lancheID");

                    b.ToTable("CarrinhoCompraItens");
                });

            modelBuilder.Entity("CardapioWEB_Demo.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("CardapioWEB_Demo.Models.Lanche", b =>
                {
                    b.Property<int>("lancheID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("lancheID"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("DescricaoCurta")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DescricaoDetalhada")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("EmEstoque")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImagemThumbnailUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsLanchePreferido")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("lancheID");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Lanches");
                });

            modelBuilder.Entity("CardapioWEB_Demo.Models.CarrinhoCompraItem", b =>
                {
                    b.HasOne("CardapioWEB_Demo.Models.Lanche", "Lanche")
                        .WithMany()
                        .HasForeignKey("lancheID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lanche");
                });

            modelBuilder.Entity("CardapioWEB_Demo.Models.Lanche", b =>
                {
                    b.HasOne("CardapioWEB_Demo.Models.Categoria", "Categoria")
                        .WithMany("Lanches")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("CardapioWEB_Demo.Models.Categoria", b =>
                {
                    b.Navigation("Lanches");
                });
#pragma warning restore 612, 618
        }
    }
}
