using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations.MvcBook
{
    /// <inheritdoc />
    public partial class UpdateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_BookGenre_BookGenreId",
                table: "Book");

            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropIndex(
                name: "IX_Book_BookGenreId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "BookGenreId",
                table: "Book");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "BookGenreId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    BookGenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => x.BookGenreId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_BookGenreId",
                table: "Book",
                column: "BookGenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_BookGenre_BookGenreId",
                table: "Book",
                column: "BookGenreId",
                principalTable: "BookGenre",
                principalColumn: "BookGenreId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
