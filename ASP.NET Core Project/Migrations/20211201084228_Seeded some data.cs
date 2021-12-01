using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Project.Migrations
{
    public partial class Seededsomedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Model", "RegNumber" },
                values: new object[,]
                {
                    { 1, "Volvo", "V70", "ABC-123" },
                    { 2, "SAAB", "93", "DEF-456" },
                    { 3, "BMW", "E38", "GHI-789" }
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "SSN", "Name" },
                values: new object[,]
                {
                    { "1234567980", "Jonathan Krall" },
                    { "4564513221", "Anna Andersson" },
                    { "523423423", "Robin Robinsson" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "SSN",
                keyValue: "1234567980");

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "SSN",
                keyValue: "4564513221");

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "SSN",
                keyValue: "523423423");
        }
    }
}
