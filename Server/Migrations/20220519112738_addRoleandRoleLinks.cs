using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZAI.Server.Migrations
{
    public partial class addRoleandRoleLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "DataBrowsing" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "DataEditing" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "UserEditing" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddTime", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 19, 13, 27, 38, 149, DateTimeKind.Local).AddTicks(5644), "$2a$11$Ze9Ujxqq0KSzJtiJ1HBFj.AcdB.VmZiAYTGZaYreEqPmqST7w/jU." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddTime", "Login", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 19, 13, 27, 38, 320, DateTimeKind.Local).AddTicks(1793), "arek", "$2a$11$UDLCR4a1pT79mrRa0saINuMmMLlXUiDWx5n.TgCSsNtjiwKC4IAXW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddTime", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 19, 13, 27, 38, 475, DateTimeKind.Local).AddTicks(9798), "$2a$11$bAOUNELSMYDLPA/CXPyOReO6Kfh0cm.O5W4GQHFZ5wUnUvR7jTBfa" });

            migrationBuilder.InsertData(
                table: "RolesLinks",
                columns: new[] { "Id", "RoleID", "UserID" },
                values: new object[] { 5, 3, 1 });

            migrationBuilder.InsertData(
                table: "RolesLinks",
                columns: new[] { "Id", "RoleID", "UserID" },
                values: new object[] { 6, 3, 2 });

            migrationBuilder.InsertData(
                table: "RolesLinks",
                columns: new[] { "Id", "RoleID", "UserID" },
                values: new object[] { 7, 3, 3 });

            migrationBuilder.InsertData(
                table: "RolesLinks",
                columns: new[] { "Id", "RoleID", "UserID" },
                values: new object[] { 8, 4, 2 });

            migrationBuilder.InsertData(
                table: "RolesLinks",
                columns: new[] { "Id", "RoleID", "UserID" },
                values: new object[] { 9, 4, 3 });

            migrationBuilder.InsertData(
                table: "RolesLinks",
                columns: new[] { "Id", "RoleID", "UserID" },
                values: new object[] { 10, 5, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolesLinks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RolesLinks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RolesLinks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RolesLinks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RolesLinks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RolesLinks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddTime", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 19, 8, 14, 58, 232, DateTimeKind.Local).AddTicks(148), "$2a$11$0UV5Ilxu5dswKKyLdmZobODOMShF4HQA74ejhiy4rJvZ8VBkJuSpy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddTime", "Login", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 19, 8, 14, 58, 384, DateTimeKind.Local).AddTicks(9261), "user2", "$2a$11$vKJvQHCPrwRKMWC7yrW6hecQTl.x5sO.adMMoGR51qqT7GlIenr4." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddTime", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 19, 8, 14, 58, 532, DateTimeKind.Local).AddTicks(7866), "$2a$11$2hQCO0eMGHPaVounsUT8TepeiJPlwkdVJSFnJYJXjkvR1npqCLBVq" });
        }
    }
}
