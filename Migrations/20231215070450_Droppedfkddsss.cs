using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractApi.Migrations
{
    public partial class Droppedfkddsss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_ContractDetail_ConId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractDetail",
                table: "ContractDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "ContractDetail",
                newName: "Contract");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameIndex(
                name: "IX_Books_ConId",
                table: "Book",
                newName: "IX_Book_ConId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contract",
                table: "Contract",
                column: "ConId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Contract_ConId",
                table: "Book",
                column: "ConId",
                principalTable: "Contract",
                principalColumn: "ConId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Contract_ConId",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contract",
                table: "Contract");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "Contract",
                newName: "ContractDetail");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_Book_ConId",
                table: "Books",
                newName: "IX_Books_ConId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractDetail",
                table: "ContractDetail",
                column: "ConId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_ContractDetail_ConId",
                table: "Books",
                column: "ConId",
                principalTable: "ContractDetail",
                principalColumn: "ConId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
