using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractApi.Migrations
{
    public partial class Dropp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contract",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "ConId",
                table: "Contract");

            migrationBuilder.RenameTable(
                name: "Contract",
                newName: "CrContract");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "CrContract",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CrContract",
                table: "CrContract",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CrContract",
                table: "CrContract");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CrContract");

            migrationBuilder.RenameTable(
                name: "CrContract",
                newName: "Contract");

            migrationBuilder.AddColumn<int>(
                name: "ConId",
                table: "Contract",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contract",
                table: "Contract",
                column: "ConId");

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Book_Contract_ConId",
                        column: x => x.ConId,
                        principalTable: "Contract",
                        principalColumn: "ConId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_ConId",
                table: "Book",
                column: "ConId");
        }
    }
}
