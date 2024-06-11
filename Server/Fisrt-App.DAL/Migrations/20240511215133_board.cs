using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fisrt_App.DAL.Migrations
{
    /// <inheritdoc />
    public partial class board : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "BoardId",
                table: "ListBoards",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BoardId",
                table: "Cards",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListBoards_BoardId",
                table: "ListBoards",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_BoardId",
                table: "Cards",
                column: "BoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Boards_BoardId",
                table: "Cards",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListBoards_Boards_BoardId",
                table: "ListBoards",
                column: "BoardId",
                principalTable: "Boards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Boards_BoardId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_ListBoards_Boards_BoardId",
                table: "ListBoards");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropIndex(
                name: "IX_ListBoards_BoardId",
                table: "ListBoards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_BoardId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "ListBoards");

            migrationBuilder.DropColumn(
                name: "BoardId",
                table: "Cards");

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
        }
    }
}
