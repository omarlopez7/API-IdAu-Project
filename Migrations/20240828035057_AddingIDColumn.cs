using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_IdAu1.Migrations
{
    /// <inheritdoc />
    public partial class AddingIDColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be3e0485-4aef-40e5-9150-87815ec22a21");

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d58824b8-db84-4e59-befb-7478bb5734b7");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "be3e0485-4aef-40e5-9150-87815ec22a21", null, "Admin", "ADMIN" },
                    { "d58824b8-db84-4e59-befb-7478bb5734b7", null, "User", "USER" }
                });
        }
    }
}
