using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_IdAu1.Migrations
{
    /// <inheritdoc />
    public partial class AddingIdUserColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daab29fb-9f5e-4644-858b-aae57f90f46b");

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe7079da-eee6-4cf0-826e-01ef848329df");

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                schema: "identity",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                schema: "identity",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "488fa69d-bd0a-4b4b-b7ec-91206fc300a2", null, "Admin", "ADMIN" },
                    { "f0c48167-794f-458e-9a16-c971df12f303", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "488fa69d-bd0a-4b4b-b7ec-91206fc300a2");

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0c48167-794f-458e-9a16-c971df12f303");

            migrationBuilder.DropColumn(
                name: "IdUser",
                schema: "identity",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                schema: "identity",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "daab29fb-9f5e-4644-858b-aae57f90f46b", null, "User", "USER" },
                    { "fe7079da-eee6-4cf0-826e-01ef848329df", null, "Admin", "ADMIN" }
                });
        }
    }
}
