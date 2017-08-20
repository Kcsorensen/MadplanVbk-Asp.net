using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MadplanVbkAsp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuantityConverters",
                columns: table => new
                {
                    QuantityConverterId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuantityConverters", x => x.QuantityConverterId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    EnergiKcal = table.Column<string>(maxLength: 50, nullable: true),
                    EnergiKj = table.Column<string>(maxLength: 50, nullable: true),
                    Kostfiber = table.Column<string>(maxLength: 50, nullable: true),
                    KulhydratDifferens = table.Column<string>(maxLength: 50, nullable: true),
                    KulhydratTilgaengelig = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    ProteinTotal = table.Column<string>(maxLength: 50, nullable: true),
                    QuantityConverterId = table.Column<int>(nullable: true),
                    TilsatSukker = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_QuantityConverters_QuantityConverterId",
                        column: x => x.QuantityConverterId,
                        principalTable: "QuantityConverters",
                        principalColumn: "QuantityConverterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quantities",
                columns: table => new
                {
                    QuantityId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    Name = table.Column<string>(nullable: true),
                    QuantityConverterId = table.Column<int>(nullable: true),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quantities", x => x.QuantityId);
                    table.ForeignKey(
                        name: "FK_Quantities_QuantityConverters_QuantityConverterId",
                        column: x => x.QuantityConverterId,
                        principalTable: "QuantityConverters",
                        principalColumn: "QuantityConverterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_QuantityConverterId",
                table: "Foods",
                column: "QuantityConverterId");

            migrationBuilder.CreateIndex(
                name: "IX_Quantities_QuantityConverterId",
                table: "Quantities",
                column: "QuantityConverterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Quantities");

            migrationBuilder.DropTable(
                name: "QuantityConverters");
        }
    }
}
