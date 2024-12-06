using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Courses.Migrations
{
    /// <inheritdoc />
    public partial class Comment_Tags_in_Lesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lessons with Tags");

            migrationBuilder.AddColumn<Guid>(
                name: "TagId",
                table: "AppLessons",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppLessons_TagId",
                table: "AppLessons",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppLessons_AppTags_TagId",
                table: "AppLessons",
                column: "TagId",
                principalTable: "AppTags",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppLessons_AppTags_TagId",
                table: "AppLessons");

            migrationBuilder.DropIndex(
                name: "IX_AppLessons_TagId",
                table: "AppLessons");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "AppLessons");

            migrationBuilder.CreateTable(
                name: "Lessons with Tags",
                columns: table => new
                {
                    LessonsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TagsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons with Tags", x => new { x.LessonsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_Lessons with Tags_AppLessons_LessonsId",
                        column: x => x.LessonsId,
                        principalTable: "AppLessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lessons with Tags_AppTags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "AppTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons with Tags_TagsId",
                table: "Lessons with Tags",
                column: "TagsId");
        }
    }
}
