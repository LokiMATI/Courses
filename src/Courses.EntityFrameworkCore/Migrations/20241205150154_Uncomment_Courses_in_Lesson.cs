using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Courses.Migrations
{
    /// <inheritdoc />
    public partial class Uncomment_Courses_in_Lesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CourseId",
                table: "AppLessons",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AppLessons_CourseId",
                table: "AppLessons",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppLessons_AppCourses_CourseId",
                table: "AppLessons",
                column: "CourseId",
                principalTable: "AppCourses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppLessons_AppCourses_CourseId",
                table: "AppLessons");

            migrationBuilder.DropIndex(
                name: "IX_AppLessons_CourseId",
                table: "AppLessons");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "AppLessons");
        }
    }
}
