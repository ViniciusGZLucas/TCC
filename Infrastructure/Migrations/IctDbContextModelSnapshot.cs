﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(IctDbContext))]
    partial class IctDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entry.Article", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("AdvisorCurriculumLink")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<long>("AdvisorId")
                        .HasColumnType("bigint");

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ChangeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("ChangeUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("CoAdvisorCurriculumLink")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<long>("CoAdvisorId")
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

                    b.Property<string>("File")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

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

                    b.ToTable("Article");
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

                    b.Property<long>("CreationUserId")
                        .HasColumnType("bigint");

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

                    b.HasIndex("CreationUserId");

                    b.ToTable("Users");
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
                });

            modelBuilder.Entity("Domain.Entry.Article", b =>
                {
                    b.HasOne("Domain.Entry.User", "Advisor")
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

                    b.HasOne("Domain.Entry.User", "CoAdvisor")
                        .WithMany("ListArticleCoAdvisor")
                        .HasForeignKey("CoAdvisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

                    b.HasOne("Domain.Entry.User", "CreationUser")
                        .WithMany("ListCreationUser")
                        .HasForeignKey("CreationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChangeUser");

                    b.Navigation("CreationUser");
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

            modelBuilder.Entity("Domain.Entry.Role", b =>
                {
                    b.Navigation("ListUserRole");
                });

            modelBuilder.Entity("Domain.Entry.User", b =>
                {
                    b.Navigation("ListArticleAdvisor");

                    b.Navigation("ListArticleAuthor");

                    b.Navigation("ListArticleChangeUser");

                    b.Navigation("ListArticleCoAdvisor");

                    b.Navigation("ListArticleCreationUser");

                    b.Navigation("ListChangeUser");

                    b.Navigation("ListCreationUser");

                    b.Navigation("ListRoleChangeUser");

                    b.Navigation("ListRoleCreationUser");

                    b.Navigation("ListUserRole");

                    b.Navigation("ListUserRoleCreationUser");
                });
#pragma warning restore 612, 618
        }
    }
}
