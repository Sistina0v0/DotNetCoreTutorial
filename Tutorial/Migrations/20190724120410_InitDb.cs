using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tutorial.Portal.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleName = table.Column<string>(nullable: true),
                    ModifiedUser = table.Column<string>(nullable: true),
                    ModifiedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    LastLoginDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ModifiedTime", "ModifiedUser", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 7, 24, 20, 4, 10, 318, DateTimeKind.Local).AddTicks(3451), "AdminInit", "炒鸡管理员" },
                    { 2, new DateTime(2019, 7, 24, 20, 4, 10, 318, DateTimeKind.Local).AddTicks(5083), "AdminInit", "扫地阿姨" },
                    { 3, new DateTime(2019, 7, 24, 20, 4, 10, 318, DateTimeKind.Local).AddTicks(5095), "AdminInit", "部门经理" },
                    { 4, new DateTime(2019, 7, 24, 20, 4, 10, 318, DateTimeKind.Local).AddTicks(5098), "AdminInit", "HR" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Gender", "LastLoginDate", "Pwd", "UserName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 7, 24, 20, 4, 10, 315, DateTimeKind.Local).AddTicks(7413), "2", "1" },
                    { 2, 1, new DateTime(2019, 7, 24, 20, 4, 10, 316, DateTimeKind.Local).AddTicks(6418), "Admin", "Admin" },
                    { 3, 1, new DateTime(2019, 7, 24, 20, 4, 10, 316, DateTimeKind.Local).AddTicks(6433), "Zhangsan", "Zhangsan" },
                    { 4, 0, new DateTime(2019, 7, 24, 20, 4, 10, 316, DateTimeKind.Local).AddTicks(6436), "Lisi", "Lisi" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserRole");
        }
    }
}
