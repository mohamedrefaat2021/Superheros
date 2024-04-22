﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MohamedRefaat_TechnicalTest.Infra.Data.Context;

#nullable disable

namespace MohamedRefaat_TechnicalTest.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.Appearance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Eye_color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hair_color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SuperheroId")
                        .HasColumnType("int");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId")
                        .IsUnique();

                    b.ToTable("Appearances");
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.Biography", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aliases")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alignment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Alter_egos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_appearance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Full_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place_of_birth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SuperheroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId")
                        .IsUnique();

                    b.ToTable("Biographies");
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.Connections", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GroupAffiliation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relatives")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SuperheroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId")
                        .IsUnique();

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SuperheroId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId")
                        .IsUnique();

                    b.ToTable("Images");
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.PowerStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Combat")
                        .HasColumnType("int");

                    b.Property<int>("Durability")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("SuperheroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId")
                        .IsUnique();

                    b.ToTable("PowerStats");
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.Superhero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Superheros");
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Base")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SuperheroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId")
                        .IsUnique();

                    b.ToTable("Works");
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.Appearance", b =>
                {
                    b.HasOne("MohamedRefaat_TechnicalTest.Domain.Models.Superhero", null)
                        .WithOne("appearance")
                        .HasForeignKey("MohamedRefaat_TechnicalTest.Domain.Models.Appearance", "SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.Biography", b =>
                {
                    b.HasOne("MohamedRefaat_TechnicalTest.Domain.Models.Superhero", null)
                        .WithOne("biography")
                        .HasForeignKey("MohamedRefaat_TechnicalTest.Domain.Models.Biography", "SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.Connections", b =>
                {
                    b.HasOne("MohamedRefaat_TechnicalTest.Domain.Models.Superhero", null)
                        .WithOne("connections")
                        .HasForeignKey("MohamedRefaat_TechnicalTest.Domain.Models.Connections", "SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.Image", b =>
                {
                    b.HasOne("MohamedRefaat_TechnicalTest.Domain.Models.Superhero", null)
                        .WithOne("image")
                        .HasForeignKey("MohamedRefaat_TechnicalTest.Domain.Models.Image", "SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.PowerStats", b =>
                {
                    b.HasOne("MohamedRefaat_TechnicalTest.Domain.Models.Superhero", null)
                        .WithOne("powerstats")
                        .HasForeignKey("MohamedRefaat_TechnicalTest.Domain.Models.PowerStats", "SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.Work", b =>
                {
                    b.HasOne("MohamedRefaat_TechnicalTest.Domain.Models.Superhero", null)
                        .WithOne("work")
                        .HasForeignKey("MohamedRefaat_TechnicalTest.Domain.Models.Work", "SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MohamedRefaat_TechnicalTest.Domain.Models.Superhero", b =>
                {
                    b.Navigation("appearance")
                        .IsRequired();

                    b.Navigation("biography")
                        .IsRequired();

                    b.Navigation("connections")
                        .IsRequired();

                    b.Navigation("image")
                        .IsRequired();

                    b.Navigation("powerstats")
                        .IsRequired();

                    b.Navigation("work")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}