using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "book",
                columns: table => new
                {
                    book_id = table.Column<Guid>(type: "TEXT", nullable: false),
                    isbn = table.Column<string>(type: "TEXT", maxLength: 13, nullable: true),
                    title = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    author = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    genre = table.Column<string>(type: "TEXT", maxLength: 128, nullable: true),
                    isDeleted = table.Column<short>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book", x => x.book_id);
                });

            migrationBuilder.CreateTable(
                name: "user_account",
                columns: table => new
                {
                    user_account_id = table.Column<Guid>(type: "TEXT", nullable: false),
                    username = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    password = table.Column<string>(type: "TEXT", maxLength: 45, nullable: true),
                    isDeleted = table.Column<short>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_account", x => x.user_account_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "book");

            migrationBuilder.DropTable(
                name: "user_account");
        }
    }
}
