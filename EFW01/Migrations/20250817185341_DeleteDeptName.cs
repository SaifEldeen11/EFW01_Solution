using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFW01.Migrations
{
    /// <inheritdoc />
    public partial class DeleteDeptName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "departments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
