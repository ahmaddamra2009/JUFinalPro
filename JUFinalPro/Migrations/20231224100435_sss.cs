using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JUFinalPro.Migrations
{
    /// <inheritdoc />
    public partial class sss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "Courses",
                newName: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Courses",
                newName: "CoursesId");
        }
    }
}
