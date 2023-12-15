using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractApi.Migrations
{
    public partial class Oracledatagh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_contrac",
                table: "contrac");

            migrationBuilder.RenameTable(
                name: "contrac",
                newName: "crcontract");

            migrationBuilder.AddPrimaryKey(
                name: "PK_crcontract",
                table: "crcontract",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_crcontract",
                table: "crcontract");

            migrationBuilder.RenameTable(
                name: "crcontract",
                newName: "contrac");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contrac",
                table: "contrac",
                column: "Id");
        }
    }
}
