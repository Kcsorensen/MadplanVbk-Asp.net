using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MadplanVbkAsp.Data;

namespace MadplanVbkAsp.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20170820193302_foo2")]
    partial class foo2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("MadplanVbkAsp.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EnergiKcal")
                        .HasMaxLength(50);

                    b.Property<string>("EnergiKj")
                        .HasMaxLength(50);

                    b.Property<string>("Kostfiber")
                        .HasMaxLength(50);

                    b.Property<string>("KulhydratDifferens")
                        .HasMaxLength(50);

                    b.Property<string>("KulhydratTilgaengelig")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ProteinTotal")
                        .HasMaxLength(50);

                    b.Property<int?>("QuantityConverterId");

                    b.Property<string>("TilsatSukker")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("QuantityConverterId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("MadplanVbkAsp.Models.Quantity", b =>
                {
                    b.Property<int>("QuantityId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int?>("QuantityConverterId");

                    b.Property<double>("Value");

                    b.HasKey("QuantityId");

                    b.HasIndex("QuantityConverterId");

                    b.ToTable("Quantities");
                });

            modelBuilder.Entity("MadplanVbkAsp.Models.QuantityConverter", b =>
                {
                    b.Property<int>("QuantityConverterId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("QuantityConverterId");

                    b.ToTable("QuantityConverters");
                });

            modelBuilder.Entity("MadplanVbkAsp.Models.Food", b =>
                {
                    b.HasOne("MadplanVbkAsp.Models.QuantityConverter", "QuantityConverter")
                        .WithMany()
                        .HasForeignKey("QuantityConverterId");
                });

            modelBuilder.Entity("MadplanVbkAsp.Models.Quantity", b =>
                {
                    b.HasOne("MadplanVbkAsp.Models.QuantityConverter")
                        .WithMany("Quantities")
                        .HasForeignKey("QuantityConverterId");
                });
        }
    }
}
