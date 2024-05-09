using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fisrt_App.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Cards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_ListBoards_ListBoardId",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "Cards");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_ListBoardId",
                table: "Cards",
                newName: "IX_Cards_ListBoardId");

            migrationBuilder.AlterColumn<int>(
                name: "ListBoardId",
                table: "Cards",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Cards",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "Id");

            migrationBuilder.InsertData(
                table: "ListBoards",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "MyBoard1" },
                    { 2, "MyBoard2" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Deadline", "Description", "ListBoardId", "Title" },
                values: new object[,]
                {
                    { 1, new DateOnly(1, 1, 1), "MyDescription1", 1, "MyCard1" },
                    { 4, new DateOnly(1, 1, 1), "MyDescription2", 1, "MyCard2" },
                    { 5, new DateOnly(1, 1, 1), "MyDescription3", 1, "MyCard3" },
                    { 6, new DateOnly(1, 1, 1), "MyDescription4", 1, "MyCard4" },
                    { 7, new DateOnly(1, 1, 1), "MyDescription5", 1, "MyCard5" },
                    { 8, new DateOnly(1, 1, 1), "MyDescription6", 2, "MyCard6" },
                    { 9, new DateOnly(1, 1, 1), "MyDescription7", 2, "MyCard7" },
                    { 10, new DateOnly(1, 1, 1), "MyDescription8", 2, "MyCard8" },
                    { 11, new DateOnly(1, 1, 1), "MyDescription9", 2, "MyCard9" },
                    { 12, new DateOnly(1, 1, 1), "MyDescription10", 2, "MyCard10" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_ListBoards_ListBoardId",
                table: "Cards",
                column: "ListBoardId",
                principalTable: "ListBoards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_ListBoards_ListBoardId",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ListBoards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ListBoards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "Cars");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_ListBoardId",
                table: "Cars",
                newName: "IX_Cars_ListBoardId");

            migrationBuilder.AlterColumn<int>(
                name: "ListBoardId",
                table: "Cars",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Cars",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_ListBoards_ListBoardId",
                table: "Cars",
                column: "ListBoardId",
                principalTable: "ListBoards",
                principalColumn: "Id");
        }
    }
}
