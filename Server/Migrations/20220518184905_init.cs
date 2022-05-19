using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZAI.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adressess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ZipCode = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Province = table.Column<string>(type: "TEXT", nullable: false),
                    District = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adressess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    AddTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolesLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false),
                    RoleID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolesLinks_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolesLinks_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adressess",
                columns: new[] { "Id", "Address", "City", "District", "Province", "ZipCode" },
                values: new object[] { 1, "Słoneczna 1", "Poznań", "Poznańskie", "Wielkopolskie", "60-001" });

            migrationBuilder.InsertData(
                table: "Adressess",
                columns: new[] { "Id", "Address", "City", "District", "Province", "ZipCode" },
                values: new object[] { 2, "Makowa 5C", "Poznań", "Poznańskie", "Wielkopolskie", "60-001" });

            migrationBuilder.InsertData(
                table: "Adressess",
                columns: new[] { "Id", "Address", "City", "District", "Province", "ZipCode" },
                values: new object[] { 3, "Piaskowa 1b", "Poznań", "Poznańskie", "Wielkopolskie", "60-001" });

            migrationBuilder.InsertData(
                table: "Adressess",
                columns: new[] { "Id", "Address", "City", "District", "Province", "ZipCode" },
                values: new object[] { 4, "Pythonowa 16", "Poznań", "Poznańskie", "Wielkopolskie", "60-001" });

            migrationBuilder.InsertData(
                table: "Adressess",
                columns: new[] { "Id", "Address", "City", "District", "Province", "ZipCode" },
                values: new object[] { 5, "Javascriptowa 1", "Poznań", "Poznańskie", "Wielkopolskie", "60-001" });

            migrationBuilder.InsertData(
                table: "Adressess",
                columns: new[] { "Id", "Address", "City", "District", "Province", "ZipCode" },
                values: new object[] { 6, "Hakerska 21/37", "Poznań", "Poznańskie", "Wielkopolskie", "60-001" });

            migrationBuilder.InsertData(
                table: "Adressess",
                columns: new[] { "Id", "Address", "City", "District", "Province", "ZipCode" },
                values: new object[] { 7, "Drewniana 9/2", "Poznań", "Poznańskie", "Wielkopolskie", "60-001" });

            migrationBuilder.InsertData(
                table: "Adressess",
                columns: new[] { "Id", "Address", "City", "District", "Province", "ZipCode" },
                values: new object[] { 8, "Gruszkowa 4", "Poznań", "Poznańskie", "Wielkopolskie", "60-001" });

            migrationBuilder.InsertData(
                table: "Adressess",
                columns: new[] { "Id", "Address", "City", "District", "Province", "ZipCode" },
                values: new object[] { 9, "Humusowa 18", "Poznań", "Poznańskie", "Wielkopolskie", "60-001" });

            migrationBuilder.InsertData(
                table: "Adressess",
                columns: new[] { "Id", "Address", "City", "District", "Province", "ZipCode" },
                values: new object[] { 10, "Jana Wazy 13", "Poznań", "Poznańskie", "Wielkopolskie", "60-001" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "User" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Administrator" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddTime", "Login", "PasswordHash" },
                values: new object[] { 1, new DateTime(2022, 5, 18, 20, 49, 4, 647, DateTimeKind.Local).AddTicks(1625), "user", "$2a$11$MYirFvjW6QlQr8q/hsvF5Oe4zZe.MGBxikLOKQnKqB/CrbeJU5Wqy" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddTime", "Login", "PasswordHash" },
                values: new object[] { 2, new DateTime(2022, 5, 18, 20, 49, 4, 825, DateTimeKind.Local).AddTicks(7444), "user2", "$2a$11$7s1I9.ZOow7GSqX8/Bi2K.0EfPjyTgv909BRwIjfZZyCUN/LqjGVG" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddTime", "Login", "PasswordHash" },
                values: new object[] { 3, new DateTime(2022, 5, 18, 20, 49, 4, 983, DateTimeKind.Local).AddTicks(8533), "user3", "$2a$11$3tKkiv6k2a5w/4SUumozze9fWOMC4smH0MRa7AVbOZxuUGxOaqbdm" });

            migrationBuilder.InsertData(
                table: "RolesLinks",
                columns: new[] { "Id", "RoleID", "UserID" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "RolesLinks",
                columns: new[] { "Id", "RoleID", "UserID" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "RolesLinks",
                columns: new[] { "Id", "RoleID", "UserID" },
                values: new object[] { 3, 1, 3 });

            migrationBuilder.InsertData(
                table: "RolesLinks",
                columns: new[] { "Id", "RoleID", "UserID" },
                values: new object[] { 4, 2, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_RolesLinks_RoleID",
                table: "RolesLinks",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_RolesLinks_UserID",
                table: "RolesLinks",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adressess");

            migrationBuilder.DropTable(
                name: "RolesLinks");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
