using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractApi.Migrations
{
    public partial class Oracledatagfsdfh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_crcontract",
                table: "crcontract");

            migrationBuilder.RenameTable(
                name: "crcontract",
                newName: "contracts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contracts",
                table: "contracts",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_contracts",
                table: "contracts");

            migrationBuilder.RenameTable(
                name: "contracts",
                newName: "crcontract");

            migrationBuilder.AddPrimaryKey(
                name: "PK_crcontract",
                table: "crcontract",
                column: "Id");
        }
    }
}
