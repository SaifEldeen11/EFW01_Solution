using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFW01.Migrations
{
    /// <inheritdoc />
    public partial class AddCname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CName",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CName",
                table: "courses");
        }
    }
}
