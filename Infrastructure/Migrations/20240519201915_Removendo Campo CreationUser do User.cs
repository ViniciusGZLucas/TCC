using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class RemovendoCampoCreationUserdoUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_AdvisorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_CoAdvisorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_CreationUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CreationUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreationUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AdvisorCurriculumLink",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "CoAdvisorCurriculumLink",
                table: "Articles");

            migrationBuilder.AddColumn<long>(
                name: "CourseId",
                table: "Articles",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreationUserId = table.Column<long>(type: "bigint", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ChangeUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Users_ChangeUserId",
                        column: x => x.ChangeUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Course_Users_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Advisor",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CurriculumLink = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseId = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreationUserId = table.Column<long>(type: "bigint", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ChangeUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advisor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advisor_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advisor_Users_ChangeUserId",
                        column: x => x.ChangeUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Advisor_Users_CreationUserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CourseId",
                table: "Articles",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Advisor_ChangeUserId",
                table: "Advisor",
                column: "ChangeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Advisor_CourseId",
                table: "Advisor",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Advisor_CreationUserId",
                table: "Advisor",
                column: "CreationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ChangeUserId",
                table: "Course",
                column: "ChangeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_CreationUserId",
                table: "Course",
                column: "CreationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Advisor_AdvisorId",
                table: "Articles",
                column: "AdvisorId",
                principalTable: "Advisor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Advisor_CoAdvisorId",
                table: "Articles",
                column: "CoAdvisorId",
                principalTable: "Advisor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Course_CourseId",
                table: "Articles",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Advisor_AdvisorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Advisor_CoAdvisorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Course_CourseId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "Advisor");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CourseId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Articles");

            migrationBuilder.AddColumn<long>(
                name: "CreationUserId",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "AdvisorCurriculumLink",
                table: "Articles",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CoAdvisorCurriculumLink",
                table: "Articles",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
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
                columns: new[] { "BindingDate", "CreationDate", "CreationUserId" },
                values: new object[] { new DateTime(2024, 5, 18, 14, 4, 26, 632, DateTimeKind.Local).AddTicks(8771), new DateTime(2024, 5, 18, 14, 4, 26, 632, DateTimeKind.Local).AddTicks(8775), 1L });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreationUserId",
                table: "Users",
                column: "CreationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_AdvisorId",
                table: "Articles",
                column: "AdvisorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_CoAdvisorId",
                table: "Articles",
                column: "CoAdvisorId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_CreationUserId",
                table: "Users",
                column: "CreationUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
