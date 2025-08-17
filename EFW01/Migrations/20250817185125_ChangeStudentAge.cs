using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFW01.Migrations
{
    /// <inheritdoc />
    public partial class ChangeStudentAge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "students",
                newName: "St_Age");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "St_Age",
                table: "students",
                newName: "Age");
        }
    }
}
