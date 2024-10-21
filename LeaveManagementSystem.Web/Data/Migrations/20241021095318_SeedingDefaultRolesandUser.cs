using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2447aa18-8ab1-4fb0-8ae8-c1870eeb534c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85e3fb94-8a85-4051-a6dc-a3f239357d92");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1569beba-2943-4893-8912-31c5955fb6fe", "408aa945-3d84-4421-8342-7269ec64d949" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1569beba-2943-4893-8912-31c5955fb6fe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d9ed3ff-bebb-42bc-ad07-0255bb0f7edb", null, "Employee", "EMPLOYEE" },
                    { "cc4fcb01-de88-4c20-b4ac-8df5c2a65160", null, "Supervisor", "SUPERVISOR" },
                    { "e9f639de-624f-4a4e-b8bf-2381725462f1", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "25b91258-6680-4a0d-be14-6cca2072b74f", new DateOnly(1950, 12, 1), "admin@localhost.com", "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHm6dFe6n33ouXVP777Reb6inkT6ACEJt7ZGs0K2FrgBXG6sTSkvDYK65fHkbPbRYA==", "3261065b-333c-45bb-90a5-8fd8134b0640", "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e9f639de-624f-4a4e-b8bf-2381725462f1", "408aa945-3d84-4421-8342-7269ec64d949" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d9ed3ff-bebb-42bc-ad07-0255bb0f7edb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc4fcb01-de88-4c20-b4ac-8df5c2a65160");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e9f639de-624f-4a4e-b8bf-2381725462f1", "408aa945-3d84-4421-8342-7269ec64d949" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9f639de-624f-4a4e-b8bf-2381725462f1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1569beba-2943-4893-8912-31c5955fb6fe", null, "Administrator", "ADMINISTRATOR" },
                    { "2447aa18-8ab1-4fb0-8ae8-c1870eeb534c", null, "Employee", "EMPLOYEE" },
                    { "85e3fb94-8a85-4051-a6dc-a3f239357d92", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7ef026af-b843-4860-90f7-6f726326d6c7", new DateOnly(2001, 7, 12), "admin@gmail.com", "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEEhF0ICmnu/N6dkX4gpDHJ0QFklqRaxYLjbZEwbIL46VT0E7mEHtU7KajZDnhFIITQ==", "4a6caba8-422b-42d4-bf89-b1b613622bf1", "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1569beba-2943-4893-8912-31c5955fb6fe", "408aa945-3d84-4421-8342-7269ec64d949" });
        }
    }
}
