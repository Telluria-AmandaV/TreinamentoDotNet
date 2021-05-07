﻿// <auto-generated />
using System;
using AppEntVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppEntVC.Migrations
{
    [DbContext(typeof(StoreDataContext))]
    [Migration("20210420211741_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AppEntVC.Models.CadSimples", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Endereco")
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("Genero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(3);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(18)")
                        .HasMaxLength(18);

                    b.HasKey("Id");

                    b.ToTable("CadSimples");
                });
#pragma warning restore 612, 618
        }
    }
}