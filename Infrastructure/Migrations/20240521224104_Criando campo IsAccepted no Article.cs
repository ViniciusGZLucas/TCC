using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class CriandocampoIsAcceptednoArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "Articles",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2024, 5, 21, 19, 41, 4, 450, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2024, 5, 21, 19, 41, 4, 452, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BindingDate", "CreationDate" },
                values: new object[] { new DateTime(2024, 5, 21, 19, 41, 4, 450, DateTimeKind.Local).AddTicks(9002), new DateTime(2024, 5, 21, 19, 41, 4, 450, DateTimeKind.Local).AddTicks(9007) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2024, 5, 19, 17, 19, 15, 171, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2024, 5, 19, 17, 19, 15, 173, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BindingDate", "CreationDate" },
                values: new object[] { new DateTime(2024, 5, 19, 17, 19, 15, 171, DateTimeKind.Local).AddTicks(3663), new DateTime(2024, 5, 19, 17, 19, 15, 171, DateTimeKind.Local).AddTicks(3667) });
        }
    }
}
