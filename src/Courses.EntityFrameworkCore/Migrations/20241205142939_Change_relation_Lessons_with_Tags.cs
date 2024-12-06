using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Courses.Migrations
{
    /// <inheritdoc />
    public partial class Change_relation_Lessons_with_Tags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonTag_AppLessons_LessonsId",
                table: "LessonTag");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonTag_AppTags_TagsId",
                table: "LessonTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LessonTag",
                table: "LessonTag");

            migrationBuilder.RenameTable(
                name: "LessonTag",
                newName: "Lessons with Tags");

            migrationBuilder.RenameIndex(
                name: "IX_LessonTag_TagsId",
                table: "Lessons with Tags",
                newName: "IX_Lessons with Tags_TagsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lessons with Tags",
                table: "Lessons with Tags",
                columns: new[] { "LessonsId", "TagsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons with Tags_AppLessons_LessonsId",
                table: "Lessons with Tags",
                column: "LessonsId",
                principalTable: "AppLessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons with Tags_AppTags_TagsId",
                table: "Lessons with Tags",
                column: "TagsId",
                principalTable: "AppTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons with Tags_AppLessons_LessonsId",
                table: "Lessons with Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons with Tags_AppTags_TagsId",
                table: "Lessons with Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lessons with Tags",
                table: "Lessons with Tags");

            migrationBuilder.RenameTable(
                name: "Lessons with Tags",
                newName: "LessonTag");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons with Tags_TagsId",
                table: "LessonTag",
                newName: "IX_LessonTag_TagsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LessonTag",
                table: "LessonTag",
                columns: new[] { "LessonsId", "TagsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_LessonTag_AppLessons_LessonsId",
                table: "LessonTag",
                column: "LessonsId",
                principalTable: "AppLessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonTag_AppTags_TagsId",
                table: "LessonTag",
                column: "TagsId",
                principalTable: "AppTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
