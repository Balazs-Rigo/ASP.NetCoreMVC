using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class RenameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullNAme",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "FullNAme",
                table: "Actors",
                newName: "FullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "FullNAme");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "FullNAme");
        }
    }
}
