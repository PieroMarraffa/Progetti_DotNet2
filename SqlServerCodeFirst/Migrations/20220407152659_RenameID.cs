using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlServerCodeFirst.Migrations
{
    public partial class RenameID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Prodotti",
                newName: "IdProdotto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdProdotto",
                table: "Prodotti",
                newName: "ID");
        }
    }
}
