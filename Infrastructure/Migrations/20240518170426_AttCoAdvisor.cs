using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AttCoAdvisor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_CoAdvisorId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "File",
                table: "Articles");

            migrationBuilder.AlterColumn<long>(
                name: "CoAdvisorId",
                table: "Articles",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "CoAdvisorCurriculumLink",
                table: "Articles",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ArticleSchedules",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArticleId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreationUserId = table.Column<long>(type: "bigint", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ChangeUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleSchedules_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleSchedules_Users_ChangeUserId",
                        column: x => x.ChangeUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArticleSchedules_Users_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2024, 5, 18, 14, 4, 26, 631, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2024, 5, 18, 14, 4, 26, 634, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BindingDate", "CreationDate" },
                values: new object[] { new DateTime(2024, 5, 18, 14, 4, 26, 632, DateTimeKind.Local).AddTicks(8771), new DateTime(2024, 5, 18, 14, 4, 26, 632, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleSchedules_ArticleId",
                table: "ArticleSchedules",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleSchedules_ChangeUserId",
                table: "ArticleSchedules",
                column: "ChangeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleSchedules_CreationUserId",
                table: "ArticleSchedules",
                column: "CreationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_CoAdvisorId",
                table: "Articles",
                column: "CoAdvisorId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_CoAdvisorId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "ArticleSchedules");

            migrationBuilder.AlterColumn<long>(
                name: "CoAdvisorId",
                table: "Articles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "CoAdvisorCurriculumLink",
                keyValue: null,
                column: "CoAdvisorCurriculumLink",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CoAdvisorCurriculumLink",
                table: "Articles",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Articles",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2024, 5, 16, 20, 26, 10, 324, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2024, 5, 16, 20, 26, 10, 328, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BindingDate", "CreationDate" },
                values: new object[] { new DateTime(2024, 5, 16, 20, 26, 10, 326, DateTimeKind.Local).AddTicks(2628), new DateTime(2024, 5, 16, 20, 26, 10, 326, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_CoAdvisorId",
                table: "Articles",
                column: "CoAdvisorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
