﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tutorial.Portal.DbContext;

namespace Tutorial.Portal.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190724120410_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tutorial.Portal.EntityModel.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ModifiedTime");

                    b.Property<string>("ModifiedUser");

                    b.Property<string>("RoleName");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ModifiedTime = new DateTime(2019, 7, 24, 20, 4, 10, 318, DateTimeKind.Local).AddTicks(3451),
                            ModifiedUser = "AdminInit",
                            RoleName = "炒鸡管理员"
                        },
                        new
                        {
                            Id = 2,
                            ModifiedTime = new DateTime(2019, 7, 24, 20, 4, 10, 318, DateTimeKind.Local).AddTicks(5083),
                            ModifiedUser = "AdminInit",
                            RoleName = "扫地阿姨"
                        },
                        new
                        {
                            Id = 3,
                            ModifiedTime = new DateTime(2019, 7, 24, 20, 4, 10, 318, DateTimeKind.Local).AddTicks(5095),
                            ModifiedUser = "AdminInit",
                            RoleName = "部门经理"
                        },
                        new
                        {
                            Id = 4,
                            ModifiedTime = new DateTime(2019, 7, 24, 20, 4, 10, 318, DateTimeKind.Local).AddTicks(5098),
                            ModifiedUser = "AdminInit",
                            RoleName = "HR"
                        });
                });

            modelBuilder.Entity("Tutorial.Portal.EntityModel.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Gender");

                    b.Property<DateTime>("LastLoginDate");

                    b.Property<string>("Pwd");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Gender = 1,
                            LastLoginDate = new DateTime(2019, 7, 24, 20, 4, 10, 315, DateTimeKind.Local).AddTicks(7413),
                            Pwd = "2",
                            UserName = "1"
                        },
                        new
                        {
                            Id = 2,
                            Gender = 1,
                            LastLoginDate = new DateTime(2019, 7, 24, 20, 4, 10, 316, DateTimeKind.Local).AddTicks(6418),
                            Pwd = "Admin",
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = 3,
                            Gender = 1,
                            LastLoginDate = new DateTime(2019, 7, 24, 20, 4, 10, 316, DateTimeKind.Local).AddTicks(6433),
                            Pwd = "Zhangsan",
                            UserName = "Zhangsan"
                        },
                        new
                        {
                            Id = 4,
                            Gender = 0,
                            LastLoginDate = new DateTime(2019, 7, 24, 20, 4, 10, 316, DateTimeKind.Local).AddTicks(6436),
                            Pwd = "Lisi",
                            UserName = "Lisi"
                        });
                });

            modelBuilder.Entity("Tutorial.Portal.EntityModel.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            RoleId = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            RoleId = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            RoleId = 4,
                            UserId = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
