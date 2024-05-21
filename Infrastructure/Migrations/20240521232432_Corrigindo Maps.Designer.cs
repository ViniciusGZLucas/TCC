﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(IctDbContext))]
    [Migration("20240521232432_Corrigindo Maps")]
    partial class CorrigindoMaps
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entry.Advisor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint");

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("CreationUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("CurriculumLink")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ChangeUserId");

                    b.HasIndex("CourseId");

                    b.HasIndex("CreationUserId");

                    b.ToTable("Advisors");
                });

            modelBuilder.Entity("Domain.Entry.Article", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("AdvisorId")
                        .HasColumnType("bigint");

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CoAdvisorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("CreationUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("DevolutionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AdvisorId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ChangeUserId");

                    b.HasIndex("CoAdvisorId");

                    b.HasIndex("CreationUserId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Domain.Entry.ArticleDocument", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint");

                    b.Property<string>("Base64File")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("CreationUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("ChangeUserId");

                    b.HasIndex("CreationUserId");

                    b.ToTable("ArticleDocuments");
                });

            modelBuilder.Entity("Domain.Entry.ArticleSchedule", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("ArticleId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("CreationUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("ChangeUserId");

                    b.HasIndex("CreationUserId");

                    b.ToTable("ArticleSchedules");
                });

            modelBuilder.Entity("Domain.Entry.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("CreationUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ChangeUserId");

                    b.HasIndex("CreationUserId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Domain.Entry.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("CreationUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ChangeUserId");

                    b.HasIndex("CreationUserId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDate = new DateTime(2024, 5, 21, 20, 24, 31, 796, DateTimeKind.Local).AddTicks(810),
                            CreationUserId = 1L,
                            IsAdmin = true,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("Domain.Entry.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("BindingDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)");

                    b.Property<string>("PrivateEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ChangeUserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            BindingDate = new DateTime(2024, 5, 21, 20, 24, 31, 796, DateTimeKind.Local).AddTicks(2045),
                            CreationDate = new DateTime(2024, 5, 21, 20, 24, 31, 796, DateTimeKind.Local).AddTicks(2050),
                            Email = "admin@admin.com",
                            Name = "Admin",
                            Password = "123456",
                            PrivateEmail = "privateAdmin@email.com"
                        });
                });

            modelBuilder.Entity("Domain.Entry.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("CreationUserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CreationUserId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreationDate = new DateTime(2024, 5, 21, 20, 24, 31, 798, DateTimeKind.Local).AddTicks(620),
                            CreationUserId = 1L,
                            RoleId = 1L,
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("Domain.Entry.Advisor", b =>
                {
                    b.HasOne("Domain.Entry.User", "ChangeUser")
                        .WithMany("ListAdvisorChangeUser")
                        .HasForeignKey("ChangeUserId");

                    b.HasOne("Domain.Entry.Course", "Course")
                        .WithMany("ListAdvisor")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entry.User", "CreationUser")
                        .WithMany("ListAdvisorCreationUser")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChangeUser");

                    b.Navigation("Course");

                    b.Navigation("CreationUser");
                });

            modelBuilder.Entity("Domain.Entry.Article", b =>
                {
                    b.HasOne("Domain.Entry.Advisor", "Advisor")
                        .WithMany("ListArticleAdvisor")
                        .HasForeignKey("AdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entry.User", "Author")
                        .WithMany("ListArticleAuthor")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entry.User", "ChangeUser")
                        .WithMany("ListArticleChangeUser")
                        .HasForeignKey("ChangeUserId");

                    b.HasOne("Domain.Entry.Advisor", "CoAdvisor")
                        .WithMany("ListArticleCoAdvisor")
                        .HasForeignKey("CoAdvisorId");

                    b.HasOne("Domain.Entry.User", "CreationUser")
                        .WithMany("ListArticleCreationUser")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advisor");

                    b.Navigation("Author");

                    b.Navigation("ChangeUser");

                    b.Navigation("CoAdvisor");

                    b.Navigation("CreationUser");
                });

            modelBuilder.Entity("Domain.Entry.ArticleDocument", b =>
                {
                    b.HasOne("Domain.Entry.Article", "Article")
                        .WithMany("ListArticleDocuments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entry.User", "ChangeUser")
                        .WithMany("ListArticleDocumentChangeUser")
                        .HasForeignKey("ChangeUserId");

                    b.HasOne("Domain.Entry.User", "CreationUser")
                        .WithMany("ListArticleDocumentCreationUser")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("ChangeUser");

                    b.Navigation("CreationUser");
                });

            modelBuilder.Entity("Domain.Entry.ArticleSchedule", b =>
                {
                    b.HasOne("Domain.Entry.Article", "Article")
                        .WithMany("ListArticleSchedule")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entry.User", "ChangeUser")
                        .WithMany()
                        .HasForeignKey("ChangeUserId");

                    b.HasOne("Domain.Entry.User", "CreationUser")
                        .WithMany("ListArticleScheduleCreationUser")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("ChangeUser");

                    b.Navigation("CreationUser");
                });

            modelBuilder.Entity("Domain.Entry.Course", b =>
                {
                    b.HasOne("Domain.Entry.User", "ChangeUser")
                        .WithMany("ListCourseChangeUser")
                        .HasForeignKey("ChangeUserId");

                    b.HasOne("Domain.Entry.User", "CreationUser")
                        .WithMany("ListCourseCreationUser")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChangeUser");

                    b.Navigation("CreationUser");
                });

            modelBuilder.Entity("Domain.Entry.Role", b =>
                {
                    b.HasOne("Domain.Entry.User", "ChangeUser")
                        .WithMany("ListRoleChangeUser")
                        .HasForeignKey("ChangeUserId");

                    b.HasOne("Domain.Entry.User", "CreationUser")
                        .WithMany("ListRoleCreationUser")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChangeUser");

                    b.Navigation("CreationUser");
                });

            modelBuilder.Entity("Domain.Entry.User", b =>
                {
                    b.HasOne("Domain.Entry.User", "ChangeUser")
                        .WithMany("ListChangeUser")
                        .HasForeignKey("ChangeUserId");

                    b.Navigation("ChangeUser");
                });

            modelBuilder.Entity("Domain.Entry.UserRole", b =>
                {
                    b.HasOne("Domain.Entry.User", "CreationUser")
                        .WithMany("ListUserRoleCreationUser")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entry.Role", "Role")
                        .WithMany("ListUserRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entry.User", "User")
                        .WithMany("ListUserRole")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreationUser");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entry.Advisor", b =>
                {
                    b.Navigation("ListArticleAdvisor");

                    b.Navigation("ListArticleCoAdvisor");
                });

            modelBuilder.Entity("Domain.Entry.Article", b =>
                {
                    b.Navigation("ListArticleDocuments");

                    b.Navigation("ListArticleSchedule");
                });

            modelBuilder.Entity("Domain.Entry.Course", b =>
                {
                    b.Navigation("ListAdvisor");
                });

            modelBuilder.Entity("Domain.Entry.Role", b =>
                {
                    b.Navigation("ListUserRole");
                });

            modelBuilder.Entity("Domain.Entry.User", b =>
                {
                    b.Navigation("ListAdvisorChangeUser");

                    b.Navigation("ListAdvisorCreationUser");

                    b.Navigation("ListArticleAuthor");

                    b.Navigation("ListArticleChangeUser");

                    b.Navigation("ListArticleCreationUser");

                    b.Navigation("ListArticleDocumentChangeUser");

                    b.Navigation("ListArticleDocumentCreationUser");

                    b.Navigation("ListArticleScheduleCreationUser");

                    b.Navigation("ListChangeUser");

                    b.Navigation("ListCourseChangeUser");

                    b.Navigation("ListCourseCreationUser");

                    b.Navigation("ListRoleChangeUser");

                    b.Navigation("ListRoleCreationUser");

                    b.Navigation("ListUserRole");

                    b.Navigation("ListUserRoleCreationUser");
                });
#pragma warning restore 612, 618
        }
    }
}
