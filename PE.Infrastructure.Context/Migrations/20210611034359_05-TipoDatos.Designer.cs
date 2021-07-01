﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PE.Infrastructure.Context;

namespace PE.Infrastructure.Context.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20210611034359_05-TipoDatos")]
    partial class _05TipoDatos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PE.Domain.Entity.Alumno.Alumno", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaInscripcion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Legajo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PersonaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("Alumno");
                });

            modelBuilder.Entity("PE.Domain.Entity.Empleado.Empleado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FehcaBaja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Legajo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PersonaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("PE.Domain.Entity.Empresa.Empresa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cuit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("FechaAlta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("PE.Domain.Entity.Galeria.Galeria", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<long>("EmpresaId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Galeria");
                });

            modelBuilder.Entity("PE.Domain.Entity.Novedades.Novedades", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<long>("EmpresaId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Novedades");
                });

            modelBuilder.Entity("PE.Domain.Entity.PerfilHome.PerfilHome", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<long>("EmpresaId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("PerfilHome");
                });

            modelBuilder.Entity("PE.Domain.Entity.Persona.Persona", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cuil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domicilio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("PE.Domain.Entity.Profesor.Profesor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("Legajo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PersonaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("PE.Domain.Entity.Usuario.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cargo")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<long>("EmpresaId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PersonaId")
                        .HasColumnType("bigint");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("PE.Domain.Entity.Alumno.Alumno", b =>
                {
                    b.HasOne("PE.Domain.Entity.Persona.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PE.Domain.Entity.Empleado.Empleado", b =>
                {
                    b.HasOne("PE.Domain.Entity.Persona.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PE.Domain.Entity.Galeria.Galeria", b =>
                {
                    b.HasOne("PE.Domain.Entity.Empresa.Empresa", "Empresa")
                        .WithMany("Galeria")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PE.Domain.Entity.Novedades.Novedades", b =>
                {
                    b.HasOne("PE.Domain.Entity.Empresa.Empresa", "Empresa")
                        .WithMany("Novedades")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PE.Domain.Entity.PerfilHome.PerfilHome", b =>
                {
                    b.HasOne("PE.Domain.Entity.Empresa.Empresa", "Empresa")
                        .WithMany("PerfilHome")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PE.Domain.Entity.Profesor.Profesor", b =>
                {
                    b.HasOne("PE.Domain.Entity.Persona.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PE.Domain.Entity.Usuario.Usuario", b =>
                {
                    b.HasOne("PE.Domain.Entity.Empresa.Empresa", "Empresa")
                        .WithMany("Usuario")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PE.Domain.Entity.Persona.Persona", "Persona")
                        .WithMany("Usuarios")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
