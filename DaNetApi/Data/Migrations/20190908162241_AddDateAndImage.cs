using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DaNetApi.Data.Migrations
{
    public partial class AddDateAndImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PostDate",
                table: "Posts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PostImage",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostDate",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostImage",
                table: "Posts");
        }
    }
}
