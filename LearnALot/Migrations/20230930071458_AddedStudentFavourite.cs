using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnALot.Migrations
{
    /// <inheritdoc />
    public partial class AddedStudentFavourite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Favourite",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Favourite",
                table: "Students");
        }
    }
}
