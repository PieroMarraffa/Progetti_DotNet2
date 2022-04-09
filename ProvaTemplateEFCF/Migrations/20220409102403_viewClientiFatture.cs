using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaTemplateEFCF.Migrations
{
    public partial class viewClientiFatture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //metto il comando per creare la view
            migrationBuilder.Sql("create view ViewLibri as " +
                                 "select Libri.Titolo as Titolo, Libri.Prezzo as Prezzo, Autori.Nome as NomeAutore, Autori.Cognome as CognomeAutore, Editori.Descrizione as Editore, Editori.Sede as SedeEditore " +
                                 "from Libri " +
                                 "inner join Autori " +
                                 "on Autori.ID = Libri.IdAutore " +
                                 "inner join Editori " +
                                 "on Editori.ID = Libri.IdEditore;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //creo la drop view
            migrationBuilder.Sql("drop view viewLibri");
        }
    }
}
