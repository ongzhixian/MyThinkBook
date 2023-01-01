using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyThinkBook.Web.Migrations.BookstoreDb
{
    /// <inheritdoc />
    public partial class _202212312046 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "author",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookstoreBookId = table.Column<int>(type: "INTEGER", nullable: true),
                    firstname = table.Column<string>(name: "first_name", type: "TEXT", nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "TEXT", nullable: false),
                    middlename = table.Column<string>(name: "middle_name", type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("author_pk", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "book",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookstoreAuthorId = table.Column<int>(type: "INTEGER", nullable: true),
                    title = table.Column<string>(type: "TEXT", nullable: false),
                    isbn = table.Column<string>(type: "TEXT", nullable: false),
                    format = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("book_pk", x => x.id);
                    table.ForeignKey(
                        name: "author__book_fk",
                        column: x => x.BookstoreAuthorId,
                        principalTable: "author",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_author_BookstoreBookId",
                table: "author",
                column: "BookstoreBookId");

            migrationBuilder.CreateIndex(
                name: "IX_book_BookstoreAuthorId",
                table: "book",
                column: "BookstoreAuthorId");

            migrationBuilder.AddForeignKey(
                name: "book__author_fk",
                table: "author",
                column: "BookstoreBookId",
                principalTable: "book",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "book__author_fk",
                table: "author");

            migrationBuilder.DropTable(
                name: "book");

            migrationBuilder.DropTable(
                name: "author");
        }
    }
}
