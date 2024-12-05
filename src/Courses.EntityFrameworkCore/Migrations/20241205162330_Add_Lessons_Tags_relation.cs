using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Courses.Migrations
{
    /// <inheritdoc />
    public partial class Add_Lessons_Tags_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LessonsId",
                table: "AppTags");

            migrationBuilder.CreateTable(
                name: "LessonTag",
                columns: table => new
                {
                    LessonsId = table.Column<Guid>(type: "uuid", nullable: false),
                    TagsTagName = table.Column<string>(type: "character varying(32)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonTag", x => new { x.LessonsId, x.TagsTagName });
                    table.ForeignKey(
                        name: "FK_LessonTag_AppLessons_LessonsId",
                        column: x => x.LessonsId,
                        principalTable: "AppLessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonTag_AppTags_TagsTagName",
                        column: x => x.TagsTagName,
                        principalTable: "AppTags",
                        principalColumn: "TagName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LessonTag_TagsTagName",
                table: "LessonTag",
                column: "TagsTagName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonTag");

            migrationBuilder.AddColumn<List<Guid>>(
                name: "LessonsId",
                table: "AppTags",
                type: "uuid[]",
                nullable: false);
        }
    }
}
