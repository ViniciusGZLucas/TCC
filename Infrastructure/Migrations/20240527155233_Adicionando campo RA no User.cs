using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AdicionandocampoRAnoUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RA",
                table: "Users",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2024, 5, 27, 12, 52, 33, 577, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2024, 5, 27, 12, 52, 33, 579, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BindingDate", "CreationDate", "RA" },
                values: new object[] { new DateTime(2024, 5, 27, 12, 52, 33, 578, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 5, 27, 12, 52, 33, 578, DateTimeKind.Local).AddTicks(304), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RA",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2024, 5, 21, 20, 24, 31, 796, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2024, 5, 21, 20, 24, 31, 798, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BindingDate", "CreationDate" },
                values: new object[] { new DateTime(2024, 5, 21, 20, 24, 31, 796, DateTimeKind.Local).AddTicks(2045), new DateTime(2024, 5, 21, 20, 24, 31, 796, DateTimeKind.Local).AddTicks(2050) });
        }
    }
}
