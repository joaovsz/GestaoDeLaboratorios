using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoDeLaboratorios.Migrations
{
    /// <inheritdoc />
    public partial class inf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: true),
                    Processador = table.Column<string>(type: "TEXT", nullable: true),
                    PlacaMae = table.Column<string>(type: "TEXT", nullable: true),
                    Memoria = table.Column<string>(type: "TEXT", nullable: true),
                    HD = table.Column<string>(type: "TEXT", nullable: true),
                    NumeroPatrimonio = table.Column<string>(type: "TEXT", nullable: true),
                    DataCompra = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computadores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computadores");
        }
    }
}
