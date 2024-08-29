using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_IdAu1.Migrations
{
    /// <inheritdoc />
    public partial class AddingIdUserColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12fd2624-7be8-4ac7-a9ac-7b09c10d8946");

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91b84fda-9789-48d6-ab9a-a459184e99a6");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                schema: "identity",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12fd2624-7be8-4ac7-a9ac-7b09c10d8946", null, "Admin", "ADMIN" },
                    { "91b84fda-9789-48d6-ab9a-a459184e99a6", null, "User", "USER" }
                });
        }
    }
}
