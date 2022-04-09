using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaTemplateEFCF.Migrations
{
    public partial class titoloTitolo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "titolo",
                table: "Libri",
                newName: "Titolo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titolo",
                table: "Libri",
                newName: "titolo");
        }
    }
}
