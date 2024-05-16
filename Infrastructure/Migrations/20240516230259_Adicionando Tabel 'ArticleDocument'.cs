using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AdicionandoTabelArticleDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Users_AdvisorId",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_Users_AuthorId",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_Users_ChangeUserId",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_Users_CoAdvisorId",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_Users_CreationUserId",
                table: "Article");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Article",
                table: "Article");

            migrationBuilder.RenameTable(
                name: "Article",
                newName: "Articles");

            migrationBuilder.RenameIndex(
                name: "IX_Article_CreationUserId",
                table: "Articles",
                newName: "IX_Articles_CreationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Article_CoAdvisorId",
                table: "Articles",
                newName: "IX_Articles_CoAdvisorId");

            migrationBuilder.RenameIndex(
                name: "IX_Article_ChangeUserId",
                table: "Articles",
                newName: "IX_Articles_ChangeUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Article_AuthorId",
                table: "Articles",
                newName: "IX_Articles_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Article_AdvisorId",
                table: "Articles",
                newName: "IX_Articles_AdvisorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ArticleDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArticleId = table.Column<long>(type: "bigint", nullable: false),
                    FileName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Base64File = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreationUserId = table.Column<long>(type: "bigint", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ChangeUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleDocuments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleDocuments_Users_ChangeUserId",
                        column: x => x.ChangeUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ArticleDocuments_Users_CreationUserId",
                        column: x => x.CreationUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BindingDate", "CreationDate" },
                values: new object[] { new DateTime(2024, 5, 16, 20, 2, 58, 974, DateTimeKind.Local).AddTicks(604), new DateTime(2024, 5, 16, 20, 2, 58, 974, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleDocuments_ArticleId",
                table: "ArticleDocuments",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleDocuments_ChangeUserId",
                table: "ArticleDocuments",
                column: "ChangeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleDocuments_CreationUserId",
                table: "ArticleDocuments",
                column: "CreationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_AdvisorId",
                table: "Articles",
                column: "AdvisorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_AuthorId",
                table: "Articles",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_ChangeUserId",
                table: "Articles",
                column: "ChangeUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_CoAdvisorId",
                table: "Articles",
                column: "CoAdvisorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Users_CreationUserId",
                table: "Articles",
                column: "CreationUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_AdvisorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_AuthorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_ChangeUserId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_CoAdvisorId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Users_CreationUserId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "ArticleDocuments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");

            migrationBuilder.RenameTable(
                name: "Articles",
                newName: "Article");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_CreationUserId",
                table: "Article",
                newName: "IX_Article_CreationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_CoAdvisorId",
                table: "Article",
                newName: "IX_Article_CoAdvisorId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_ChangeUserId",
                table: "Article",
                newName: "IX_Article_ChangeUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_AuthorId",
                table: "Article",
                newName: "IX_Article_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_AdvisorId",
                table: "Article",
                newName: "IX_Article_AdvisorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Article",
                table: "Article",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "BindingDate", "CreationDate" },
                values: new object[] { new DateTime(2024, 5, 11, 3, 38, 8, 458, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 5, 11, 3, 38, 8, 458, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Users_AdvisorId",
                table: "Article",
                column: "AdvisorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Users_AuthorId",
                table: "Article",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Users_ChangeUserId",
                table: "Article",
                column: "ChangeUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Users_CoAdvisorId",
                table: "Article",
                column: "CoAdvisorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Users_CreationUserId",
                table: "Article",
                column: "CreationUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
