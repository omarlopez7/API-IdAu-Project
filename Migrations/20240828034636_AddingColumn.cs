using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_IdAu1.Migrations
{
    /// <inheritdoc />
    public partial class AddingColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8bf06c2-e331-4866-bcbd-7e73a794e6b5");

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0326143-52b5-4633-ba5c-7da0124cd531");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "c8bf06c2-e331-4866-bcbd-7e73a794e6b5", null, "Admin", "ADMIN" },
                    { "f0326143-52b5-4633-ba5c-7da0124cd531", null, "User", "USER" }
                });
        }
    }
}
