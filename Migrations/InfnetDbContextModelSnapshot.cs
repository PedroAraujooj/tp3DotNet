﻿// <auto-generated />
using System;
using GestaoDeLaboratorios.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestaoDeLaboratorios.Migrations
{
    [DbContext(typeof(InfnetDbContext))]
    partial class InfnetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("GestaoDeLaboratorios.Models.Computador", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("DataCompra")
                        .HasColumnType("TEXT");

                    b.Property<string>("HD")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Memoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroPratrimonio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PlacaMae")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Processador")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Computadores");
                });
#pragma warning restore 612, 618
        }
    }
}
