using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AdicionandoRolePadrãoparaouserAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ChangeDate", "ChangeUserId", "CreationDate", "CreationUserId", "IsAdmin", "Name" },
                values: new object[] { 1L, null, null, new DateTime(2024, 5, 16, 20, 26, 10, 324, DateTimeKind.Local).AddTicks(3535), 1L, true, "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BindingDate", "CreationDate" },
                values: new object[] { new DateTime(2024, 5, 16, 20, 26, 10, 326, DateTimeKind.Local).AddTicks(2628), new DateTime(2024, 5, 16, 20, 26, 10, 326, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "ChangeDate", "ChangeUserId", "CreationDate", "CreationUserId", "RoleId", "UserId" },
                values: new object[] { 1L, null, null, new DateTime(2024, 5, 16, 20, 26, 10, 328, DateTimeKind.Local).AddTicks(1445), 1L, 1L, 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BindingDate", "CreationDate" },
                values: new object[] { new DateTime(2024, 5, 16, 20, 2, 58, 974, DateTimeKind.Local).AddTicks(604), new DateTime(2024, 5, 16, 20, 2, 58, 974, DateTimeKind.Local).AddTicks(621) });
        }
    }
}
