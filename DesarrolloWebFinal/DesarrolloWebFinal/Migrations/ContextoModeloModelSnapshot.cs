﻿// <auto-generated />
using DesarrolloWebFinal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesarrolloWebFinal.Migrations
{
    [DbContext(typeof(ContextoModelo))]
    partial class ContextoModeloModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DesarrolloWebFinal.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("activo");

                    b.Property<string>("apellido")
                        .IsRequired();

                    b.Property<bool>("aprobadoreprobado");

                    b.Property<string>("correo");

                    b.Property<string>("nombre")
                        .IsRequired();

                    b.Property<string>("telefono");

                    b.HasKey("Id");

                    b.ToTable("AlumnoItems");
                });

            modelBuilder.Entity("DesarrolloWebFinal.Models.Nota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idalumno");

                    b.Property<int>("idcurso");

                    b.Property<int>("nota");

                    b.HasKey("Id");

                    b.ToTable("NotaItems");
                });
#pragma warning restore 612, 618
        }
    }
}
