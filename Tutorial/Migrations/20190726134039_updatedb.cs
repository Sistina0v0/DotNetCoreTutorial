using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tutorial.Portal.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedTime",
                table: "UserRole",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedUser",
                table: "UserRole",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsDelete",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LoginName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedTime",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedUser",
                table: "User",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedTime",
                value: new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedTime",
                value: new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedTime",
                value: new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedTime",
                value: new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "LastLoginDate", "LoginName", "ModifiedTime", "ModifiedUser", "Pwd" },
                values: new object[] { new DateTime(1999, 7, 26, 21, 40, 38, 528, DateTimeKind.Local).AddTicks(8466), new DateTime(2019, 7, 26, 21, 40, 38, 527, DateTimeKind.Local).AddTicks(8689), "1", new DateTime(2019, 7, 26, 21, 40, 38, 528, DateTimeKind.Local).AddTicks(9819), "AdminInit", "1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "LastLoginDate", "LoginName", "ModifiedTime", "ModifiedUser" },
                values: new object[] { new DateTime(1997, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(290), new DateTime(2019, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(275), "Admin", new DateTime(2019, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(302), "AdminInit" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "LastLoginDate", "LoginName", "ModifiedTime", "ModifiedUser", "UserName" },
                values: new object[] { new DateTime(1996, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(305), new DateTime(2019, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(305), "Zhangsan", new DateTime(2019, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(308), "AdminInit", "张三" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "LastLoginDate", "LoginName", "ModifiedTime", "ModifiedUser", "UserName" },
                values: new object[] { new DateTime(2001, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(308), new DateTime(2019, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(308), "Lisi", new DateTime(2019, 7, 26, 21, 40, 38, 529, DateTimeKind.Local).AddTicks(311), "AdminInit", "李四" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedTime", "ModifiedUser" },
                values: new object[] { new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(6611), "AdminInit" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ModifiedTime", "ModifiedUser" },
                values: new object[] { new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(6633), "AdminInit" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ModifiedTime", "ModifiedUser" },
                values: new object[] { new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(6633), "AdminInit" });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ModifiedTime", "ModifiedUser" },
                values: new object[] { new DateTime(2019, 7, 26, 21, 40, 38, 530, DateTimeKind.Local).AddTicks(6636), "AdminInit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedTime",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "ModifiedUser",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LoginName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ModifiedTime",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ModifiedUser",
                table: "User");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedTime",
                value: new DateTime(2019, 7, 25, 20, 58, 31, 404, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedTime",
                value: new DateTime(2019, 7, 25, 20, 58, 31, 404, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedTime",
                value: new DateTime(2019, 7, 25, 20, 58, 31, 404, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedTime",
                value: new DateTime(2019, 7, 25, 20, 58, 31, 404, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "LastLoginDate", "Pwd" },
                values: new object[] { new DateTime(1999, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(8958), new DateTime(2019, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(2777), "2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "LastLoginDate" },
                values: new object[] { new DateTime(1997, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(9423), new DateTime(2019, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "LastLoginDate", "UserName" },
                values: new object[] { new DateTime(1996, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(9429), new DateTime(2019, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(9429), "Zhangsan" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "LastLoginDate", "UserName" },
                values: new object[] { new DateTime(2001, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(9432), new DateTime(2019, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(9432), "Lisi" });
        }
    }
}
