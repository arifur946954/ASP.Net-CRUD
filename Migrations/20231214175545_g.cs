using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractApi.Migrations
{
    public partial class g : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_contracts",
                table: "contracts");

            migrationBuilder.RenameTable(
                name: "contracts",
                newName: "ContractDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractDetails",
                table: "ContractDetails",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractDetails",
                table: "ContractDetails");

            migrationBuilder.RenameTable(
                name: "ContractDetails",
                newName: "contracts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contracts",
                table: "contracts",
                column: "Id");
        }
    }
}
