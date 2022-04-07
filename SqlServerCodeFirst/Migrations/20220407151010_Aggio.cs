using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlServerCodeFirst.Migrations
{
    public partial class Aggio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desccrizione",
                table: "Prodotti",
                newName: "Descrizione");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descrizione",
                table: "Prodotti",
                newName: "Desccrizione");
        }
    }
}
