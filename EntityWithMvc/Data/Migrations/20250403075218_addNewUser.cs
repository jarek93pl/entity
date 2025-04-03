using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityWithMvc.Data.Migrations
{
    /// <inheritdoc />
    public partial class addNewUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Emile",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73e5a692-d96a-4062-bdd1-cd9a50de75d2", null, "Employee", "Employee" },
                    { "83908276-c25b-4eed-be8f-c29b939e86b3", null, "Supervizor", "Supervizor" },
                    { "9c04f943-eb1b-4355-aacf-1b58a9533f8d", null, "Adninistator", "Adninistator" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "426e7c43-b617-4ddc-a7af-fa5b5e6f4e6a", 0, "2da59602-4d51-47fb-80c4-020ab584705b", "admin@localhost.com", true, false, null, "admin@localhost.com", "admin@localhost.com", "AQAAAAIAAYagAAAAEDVgXWZbCDRQy0nXBfaeDDRbPMAt7HverRiNzw5a9slwPL0/I+b9pAxHEFlRCooKkA==", null, false, "6fd1010d-66bb-4169-b70c-6a579bb56131", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9c04f943-eb1b-4355-aacf-1b58a9533f8d", "426e7c43-b617-4ddc-a7af-fa5b5e6f4e6a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73e5a692-d96a-4062-bdd1-cd9a50de75d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83908276-c25b-4eed-be8f-c29b939e86b3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9c04f943-eb1b-4355-aacf-1b58a9533f8d", "426e7c43-b617-4ddc-a7af-fa5b5e6f4e6a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c04f943-eb1b-4355-aacf-1b58a9533f8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "426e7c43-b617-4ddc-a7af-fa5b5e6f4e6a");

            migrationBuilder.DropColumn(
                name: "Emile",
                table: "Tickets");
        }
    }
}
