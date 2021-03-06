﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tutorial.Portal.DbContext;

namespace Tutorial.Portal.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            ModifiedTime = new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(4253),
                            ModifiedUser = "AdminInit",
                            RoleName = "炒鸡管理员"
                        },
                        new
                        {
                            Id = 2,
                            ModifiedTime = new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(4788),
                            ModifiedUser = "AdminInit",
                            RoleName = "扫地阿姨"
                        },
                        new
                        {
                            Id = 3,
                            ModifiedTime = new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(4797),
                            ModifiedUser = "AdminInit",
                            RoleName = "部门经理"
                        },
                        new
                        {
                            Id = 4,
                            ModifiedTime = new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(4797),
                            ModifiedUser = "AdminInit",
                            RoleName = "HR"
                        });
                });

            modelBuilder.Entity("Tutorial.Portal.EntityModel.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("Gender");

                    b.Property<int>("IsDelete");

                    b.Property<DateTime>("LastLoginDate");

                    b.Property<string>("LoginName");

                    b.Property<DateTime>("ModifiedTime");

                    b.Property<string>("ModifiedUser");

                    b.Property<string>("Pwd");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1999, 7, 26, 21, 40, 38, 528, DateTimeKind.Local).AddTicks(8466),
                            Gender = 1,
                            IsDelete = 0,
                            LastLoginDate = new DateTime(2019, 7, 26, 21, 40, 38, 527, DateTimeKind.Local).AddTicks(8689),
                            LoginName = "1",
                            ModifiedTime = new DateTime(2019, 7, 26, 21, 40, 38, 528, DateTimeKind.Local).AddTicks(9819),
                            ModifiedUser = "AdminInit",
                            Pwd = "1",
                            UserName = "1"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1997, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(290),
                            Gender = 1,
                            IsDelete = 0,
                            LastLoginDate = new DateTime(2019, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(275),
                            LoginName = "Admin",
                            ModifiedTime = new DateTime(2019, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(302),
                            ModifiedUser = "AdminInit",
                            Pwd = "Admin",
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1996, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(305),
                            Gender = 1,
                            IsDelete = 0,
                            LastLoginDate = new DateTime(2019, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(305),
                            LoginName = "Zhangsan",
                            ModifiedTime = new DateTime(2019, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(308),
                            ModifiedUser = "AdminInit",
                            Pwd = "Zhangsan",
                            UserName = "张三"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(2001, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(308),
                            Gender = 0,
                            IsDelete = 0,
                            LastLoginDate = new DateTime(2019, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(308),
                            LoginName = "Lisi",
                            ModifiedTime = new DateTime(2019, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(311),
                            ModifiedUser = "AdminInit",
                            Pwd = "Lisi",
                            UserName = "李四"
                        });
                });

            modelBuilder.Entity("Tutorial.Portal.EntityModel.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ModifiedTime");

                    b.Property<string>("ModifiedUser");

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ModifiedTime = new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(6611),
                            ModifiedUser = "AdminInit",
                            RoleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ModifiedTime = new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(6633),
                            ModifiedUser = "AdminInit",
                            RoleId = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            ModifiedTime = new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(6633),
                            ModifiedUser = "AdminInit",
                            RoleId = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            ModifiedTime = new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(6636),
                            ModifiedUser = "AdminInit",
                            RoleId = 4,
                            UserId = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
