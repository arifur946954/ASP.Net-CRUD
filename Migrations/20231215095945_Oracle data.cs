using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractApi.Migrations
{
    public partial class Oracledata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CrContract",
                table: "CrContract");

            migrationBuilder.RenameTable(
                name: "CrContract",
                newName: "contrac");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contrac",
                table: "contrac",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_contrac",
                table: "contrac");

            migrationBuilder.RenameTable(
                name: "contrac",
                newName: "CrContract");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CrContract",
                table: "CrContract",
                column: "Id");
        }
    }
}
