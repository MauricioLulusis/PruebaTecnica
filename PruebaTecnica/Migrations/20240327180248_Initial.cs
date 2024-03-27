using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaTecnica.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CUIT = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Domicilio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoCelular = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Cliente", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_Cliente",
                columns: new[] { "Id", "Apellidos", "CUIT", "Domicilio", "Email", "FechaNacimiento", "Nombres", "TelefonoCelular" },
                values: new object[,]
                {
                    { 1, "Lulusis", "20-41936341-4", "Calle Sata Catalina 3331", "mauricio.lulusis99@gmail.com", new DateTime(1999, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mauricio Nicolás", "3764160290" },
                    { 2, "Lopez", "20-45935312-4", "Itaembe Mini 223", "nicolas.sebastian@hotmail.com", new DateTime(2004, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicolas Sebastian", "376180269" },
                    { 3, "Perez", "20-43567034-4", "Rivadavia 2332", "sebasRodrigo@gmail.com", new DateTime(2006, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucas Rodrigo", "3764120590" },
                    { 4, "Correa", "24-24686668-9", "Santa Fe 2233", "misamores801@gmail.com", new DateTime(1970, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miriam Cristina", "3764178907" },
                    { 5, "Correa", "24-37905890-9", "Centanerio y Monteagudo 2222", "martincorrea899012@gmail.com", new DateTime(1970, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin ", "3764848435" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Cliente");
        }
    }
}
