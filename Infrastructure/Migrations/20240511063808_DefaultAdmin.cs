using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class DefaultAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BindingDate", "ChangeDate", "ChangeUserId", "CreationDate", "CreationUserId", "Email", "Name", "Password", "PrivateEmail" },
                values: new object[] { 1L, new DateTime(2024, 5, 11, 3, 38, 8, 458, DateTimeKind.Local).AddTicks(1621), null, null, new DateTime(2024, 5, 11, 3, 38, 8, 458, DateTimeKind.Local).AddTicks(1637), 1L, "admin@admin.com", "Admin", "123456", "privateAdmin@email.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
