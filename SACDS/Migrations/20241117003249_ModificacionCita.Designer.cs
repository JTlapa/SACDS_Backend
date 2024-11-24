﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SACDS.Modelo.EntityFramework;

#nullable disable

namespace SACDS.Migrations
{
    [DbContext(typeof(SADCDSDbContext))]
    [Migration("20241117003249_ModificacionCita")]
    partial class ModificacionCita
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SACDS.Modelo.EntityFramework.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Atendida")
                        .HasColumnType("bit");

                    b.Property<int>("DiasReposo")
                        .HasColumnType("int");

                    b.Property<int?>("DonacionUrgenteId")
                        .HasColumnType("int");

                    b.Property<int?>("DonadorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDonacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDonacionUrgente")
                        .HasColumnType("int");

                    b.Property<int>("IdDonador")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoDonacion")
                        .HasColumnType("int");

                    b.Property<int?>("TipoDonacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DonacionUrgenteId");

                    b.HasIndex("DonadorId");

                    b.HasIndex("TipoDonacionId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("SACDS.Modelo.EntityFramework.DonacionUrgente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AreaPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GrupoSanguineoPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdTipoDonacion")
                        .HasColumnType("int");

                    b.Property<string>("NombrePaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoDonacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoDonacionId");

                    b.ToTable("DonacionUrgentes");
                });

            modelBuilder.Entity("SACDS.Modelo.EntityFramework.Donador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApellidoMaterno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApellidoPaterno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contrasena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsDonador")
                        .HasColumnType("bit");

                    b.Property<string>("GrupoSanguineo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("donadors");
                });

            modelBuilder.Entity("SACDS.Modelo.EntityFramework.TipoDonacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiasReposo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tipoDonacions");
                });

            modelBuilder.Entity("SACDS.Modelo.EntityFramework.Cita", b =>
                {
                    b.HasOne("SACDS.Modelo.EntityFramework.DonacionUrgente", "DonacionUrgente")
                        .WithMany()
                        .HasForeignKey("DonacionUrgenteId");

                    b.HasOne("SACDS.Modelo.EntityFramework.Donador", "Donador")
                        .WithMany()
                        .HasForeignKey("DonadorId");

                    b.HasOne("SACDS.Modelo.EntityFramework.TipoDonacion", "TipoDonacion")
                        .WithMany()
                        .HasForeignKey("TipoDonacionId");

                    b.Navigation("DonacionUrgente");

                    b.Navigation("Donador");

                    b.Navigation("TipoDonacion");
                });

            modelBuilder.Entity("SACDS.Modelo.EntityFramework.DonacionUrgente", b =>
                {
                    b.HasOne("SACDS.Modelo.EntityFramework.TipoDonacion", "TipoDonacion")
                        .WithMany()
                        .HasForeignKey("TipoDonacionId");

                    b.Navigation("TipoDonacion");
                });
#pragma warning restore 612, 618
        }
    }
}
