using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseMono.API.Migrations
{
    public partial class UpdateTodoItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: new Guid("2d5e543d-4cfc-42a8-a6fc-f564c5a44f85"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TodoItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("927ffa0a-3674-44da-a217-60d35c650312"), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: new Guid("927ffa0a-3674-44da-a217-60d35c650312"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TodoItem");

            migrationBuilder.InsertData(
                table: "TodoItem",
                column: "Id",
                value: new Guid("2d5e543d-4cfc-42a8-a6fc-f564c5a44f85"));
        }
    }
}
