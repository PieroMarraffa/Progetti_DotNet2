using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaTemplateEFCF.Migrations
{
    public partial class CreazioneDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autori",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Cognome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autori", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Editori",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Sede = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editori", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Libri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titolo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Prezzo = table.Column<int>(type: "int", nullable: false),
                    IdAutore = table.Column<int>(type: "int", nullable: false),
                    IdEditore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Libri_Autori_IdAutore",
                        column: x => x.IdAutore,
                        principalTable: "Autori",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Libri_Editori_IdEditore",
                        column: x => x.IdEditore,
                        principalTable: "Editori",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libri_IdAutore",
                table: "Libri",
                column: "IdAutore");

            migrationBuilder.CreateIndex(
                name: "IX_Libri_IdEditore",
                table: "Libri",
                column: "IdEditore");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libri");

            migrationBuilder.DropTable(
                name: "Autori");

            migrationBuilder.DropTable(
                name: "Editori");
        }
    }
}
