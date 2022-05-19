using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZAI.Server.Migrations
{
    public partial class addToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false),
                    IsCanceled = table.Column<bool>(type: "INTEGER", nullable: false),
                    Start = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Expired = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IP = table.Column<string>(type: "TEXT", nullable: true),
                    BrowserAgent = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tokens_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "AddTime", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 19, 8, 14, 58, 384, DateTimeKind.Local).AddTicks(9261), "$2a$11$vKJvQHCPrwRKMWC7yrW6hecQTl.x5sO.adMMoGR51qqT7GlIenr4." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddTime", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 19, 8, 14, 58, 532, DateTimeKind.Local).AddTicks(7866), "$2a$11$2hQCO0eMGHPaVounsUT8TepeiJPlwkdVJSFnJYJXjkvR1npqCLBVq" });

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_UserID",
                table: "Tokens",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddTime", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 18, 20, 49, 4, 647, DateTimeKind.Local).AddTicks(1625), "$2a$11$MYirFvjW6QlQr8q/hsvF5Oe4zZe.MGBxikLOKQnKqB/CrbeJU5Wqy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddTime", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 18, 20, 49, 4, 825, DateTimeKind.Local).AddTicks(7444), "$2a$11$7s1I9.ZOow7GSqX8/Bi2K.0EfPjyTgv909BRwIjfZZyCUN/LqjGVG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddTime", "PasswordHash" },
                values: new object[] { new DateTime(2022, 5, 18, 20, 49, 4, 983, DateTimeKind.Local).AddTicks(8533), "$2a$11$3tKkiv6k2a5w/4SUumozze9fWOMC4smH0MRa7AVbOZxuUGxOaqbdm" });
        }
    }
}
