using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class CorrigindoMaps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advisor_Course_CourseId",
                table: "Advisor");

            migrationBuilder.DropForeignKey(
                name: "FK_Advisor_Users_ChangeUserId",
                table: "Advisor");

            migrationBuilder.DropForeignKey(
                name: "FK_Advisor_Users_CreationUserId",
                table: "Advisor");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Advisor_AdvisorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Advisor_CoAdvisorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Course_CourseId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Users_ChangeUserId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Users_CreationUserId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Articles_CourseId",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Advisor",
                table: "Advisor");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Articles");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameTable(
                name: "Advisor",
                newName: "Advisors");

            migrationBuilder.RenameIndex(
                name: "IX_Course_CreationUserId",
                table: "Courses",
                newName: "IX_Courses_CreationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_ChangeUserId",
                table: "Courses",
                newName: "IX_Courses_ChangeUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Advisor_CreationUserId",
                table: "Advisors",
                newName: "IX_Advisors_CreationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Advisor_CourseId",
                table: "Advisors",
                newName: "IX_Advisors_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Advisor_ChangeUserId",
                table: "Advisors",
                newName: "IX_Advisors_ChangeUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advisors",
                table: "Advisors",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Advisors_Courses_CourseId",
                table: "Advisors",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advisors_Users_ChangeUserId",
                table: "Advisors",
                column: "ChangeUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Advisors_Users_CreationUserId",
                table: "Advisors",
                column: "CreationUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Advisors_AdvisorId",
                table: "Articles",
                column: "AdvisorId",
                principalTable: "Advisors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Advisors_CoAdvisorId",
                table: "Articles",
                column: "CoAdvisorId",
                principalTable: "Advisors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_ChangeUserId",
                table: "Courses",
                column: "ChangeUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_CreationUserId",
                table: "Courses",
                column: "CreationUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advisors_Courses_CourseId",
                table: "Advisors");

            migrationBuilder.DropForeignKey(
                name: "FK_Advisors_Users_ChangeUserId",
                table: "Advisors");

            migrationBuilder.DropForeignKey(
                name: "FK_Advisors_Users_CreationUserId",
                table: "Advisors");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Advisors_AdvisorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Advisors_CoAdvisorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_ChangeUserId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_CreationUserId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Advisors",
                table: "Advisors");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameTable(
                name: "Advisors",
                newName: "Advisor");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_CreationUserId",
                table: "Course",
                newName: "IX_Course_CreationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_ChangeUserId",
                table: "Course",
                newName: "IX_Course_ChangeUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Advisors_CreationUserId",
                table: "Advisor",
                newName: "IX_Advisor_CreationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Advisors_CourseId",
                table: "Advisor",
                newName: "IX_Advisor_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Advisors_ChangeUserId",
                table: "Advisor",
                newName: "IX_Advisor_ChangeUserId");

            migrationBuilder.AddColumn<long>(
                name: "CourseId",
                table: "Articles",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advisor",
                table: "Advisor",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CourseId",
                table: "Articles",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advisor_Course_CourseId",
                table: "Advisor",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Advisor_Users_ChangeUserId",
                table: "Advisor",
                column: "ChangeUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Advisor_Users_CreationUserId",
                table: "Advisor",
                column: "CreationUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Users_ChangeUserId",
                table: "Course",
                column: "ChangeUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Users_CreationUserId",
                table: "Course",
                column: "CreationUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
