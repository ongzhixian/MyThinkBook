using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyThinkBook.Web.Migrations.BookstoreDb
{
    /// <inheritdoc />
    public partial class _202212312047 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "book__author_fk",
                table: "author");

            migrationBuilder.DropIndex(
                name: "IX_author_BookstoreBookId",
                table: "author");

            migrationBuilder.DropColumn(
                name: "BookstoreBookId",
                table: "author");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "author",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddForeignKey(
                name: "book__author_fk",
                table: "author",
                column: "id",
                principalTable: "book",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "book__author_fk",
                table: "author");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "author",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "BookstoreBookId",
                table: "author",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_author_BookstoreBookId",
                table: "author",
                column: "BookstoreBookId");

            migrationBuilder.AddForeignKey(
                name: "book__author_fk",
                table: "author",
                column: "BookstoreBookId",
                principalTable: "book",
                principalColumn: "id");
        }
    }
}
