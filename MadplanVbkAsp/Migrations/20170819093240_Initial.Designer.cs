using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MadplanVbkAsp.Data;

namespace MadplanVbkAsp.Migrations
{
    [DbContext(typeof(SqlDbContext))]
    [Migration("20170819093240_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MadplanVbkAsp.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EnergiKcal");

                    b.Property<string>("EnergiKj");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });
        }
    }
}
