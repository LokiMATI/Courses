﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Courses.Migrations
{
    /// <inheritdoc />
    public partial class Commit_Tag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppLessons_AppTags_TagName",
                table: "AppLessons");

            migrationBuilder.DropIndex(
                name: "IX_AppLessons_TagName",
                table: "AppLessons");

            migrationBuilder.DropColumn(
                name: "TagName",
                table: "AppLessons");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "AppTags",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "AppTags",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "AppTags",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "AppTags",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "AppTags",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "AppTags",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "AppTags",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<List<Guid>>(
                name: "LessonsId",
                table: "AppTags",
                type: "uuid[]",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "AppTags");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "AppTags");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "AppTags");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "AppTags");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppTags");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "AppTags");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "AppTags");

            migrationBuilder.DropColumn(
                name: "LessonsId",
                table: "AppTags");

            migrationBuilder.AddColumn<string>(
                name: "TagName",
                table: "AppLessons",
                type: "character varying(32)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppLessons_TagName",
                table: "AppLessons",
                column: "TagName");

            migrationBuilder.AddForeignKey(
                name: "FK_AppLessons_AppTags_TagName",
                table: "AppLessons",
                column: "TagName",
                principalTable: "AppTags",
                principalColumn: "TagName");
        }
    }
}
