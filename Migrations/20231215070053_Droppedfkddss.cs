using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractApi.Migrations
{
    public partial class Droppedfkddss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_ContractDetails_Id",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractDetails",
                table: "ContractDetails");

            migrationBuilder.RenameTable(
                name: "ContractDetails",
                newName: "ContractDetail");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Books",
                newName: "ConId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ContractDetail",
                newName: "ConId");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractDetail",
                table: "ContractDetail",
                column: "ConId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ConId",
                table: "Books",
                column: "ConId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_ContractDetail_ConId",
                table: "Books",
                column: "ConId",
                principalTable: "ContractDetail",
                principalColumn: "ConId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_ContractDetail_ConId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ConId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractDetail",
                table: "ContractDetail");

            migrationBuilder.RenameTable(
                name: "ContractDetail",
                newName: "ContractDetails");

            migrationBuilder.RenameColumn(
                name: "ConId",
                table: "Books",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ConId",
                table: "ContractDetails",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractDetails",
                table: "ContractDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_ContractDetails_Id",
                table: "Books",
                column: "Id",
                principalTable: "ContractDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
