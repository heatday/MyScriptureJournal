using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyScriptureJournal.Migrations
{
    /// <inheritdoc />
    public partial class Scriptures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
    

            migrationBuilder.AddColumn<string>(
                name: "Book",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Chapter",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Verse",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DateAdded",
                table: "Movie",
                type: "DateTime",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Chapter",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Verse",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "DateAdded",
                table: "Movie",
                newName: "ReleaseDate");

            
        }
    }
}
