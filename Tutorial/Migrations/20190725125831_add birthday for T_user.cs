using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tutorial.Portal.Migrations
{
    public partial class addbirthdayforT_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                columns: new[] { "BirthDate", "LastLoginDate" },
                values: new object[] { new DateTime(1999, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(8958), new DateTime(2019, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(2777) });

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
                columns: new[] { "BirthDate", "LastLoginDate" },
                values: new object[] { new DateTime(1996, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(9429), new DateTime(2019, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "LastLoginDate" },
                values: new object[] { new DateTime(2001, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(9432), new DateTime(2019, 7, 25, 20, 58, 31, 402, DateTimeKind.Local).AddTicks(9432) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "User");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedTime",
                value: new DateTime(2019, 7, 24, 20, 4, 10, 318, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModifiedTime",
                value: new DateTime(2019, 7, 24, 20, 4, 10, 318, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModifiedTime",
                value: new DateTime(2019, 7, 24, 20, 4, 10, 318, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedTime",
                value: new DateTime(2019, 7, 24, 20, 4, 10, 318, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastLoginDate",
                value: new DateTime(2019, 7, 24, 20, 4, 10, 315, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastLoginDate",
                value: new DateTime(2019, 7, 24, 20, 4, 10, 316, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastLoginDate",
                value: new DateTime(2019, 7, 24, 20, 4, 10, 316, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastLoginDate",
                value: new DateTime(2019, 7, 24, 20, 4, 10, 316, DateTimeKind.Local).AddTicks(6436));
        }
    }
}
