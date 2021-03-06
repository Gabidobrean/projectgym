// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project.Data;

namespace project.Migrations
{
    [DbContext(typeof(projectContext))]
    [Migration("20220216182952_DataCreareAbonament")]
    partial class DataCreareAbonament
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("project.Models.Abonament", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AntrenorID")
                        .HasColumnType("int");

                    b.Property<int>("CursID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCreareAbonament")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("AntrenorID");

                    b.HasIndex("CursID");

                    b.ToTable("Abonament");
                });

            modelBuilder.Entity("project.Models.Antrenor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumeAntrenor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrenumeAntrenor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ziua")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Antrenor");
                });

            modelBuilder.Entity("project.Models.Curs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DenumireCurs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dificultate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Curs");
                });

            modelBuilder.Entity("project.Models.Abonament", b =>
                {
                    b.HasOne("project.Models.Antrenor", "Antrenor")
                        .WithMany()
                        .HasForeignKey("AntrenorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project.Models.Curs", "Curs")
                        .WithMany("Abonamente")
                        .HasForeignKey("CursID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
