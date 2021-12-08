using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Project.Migrations
{
    public partial class SeededUserrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "056c1012-2def-4cfa-a683-44167a0d9d1e", "84bd5899-a34c-4d18-94a5-06c89baaad3f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84bd5899-a34c-4d18-94a5-06c89baaad3f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "056c1012-2def-4cfa-a683-44167a0d9d1e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "989d1c66-48f0-46dd-8a8f-19cbf6fcd304", "20b8debc-6582-4161-99c6-6dee4b8cd8b5", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8735557d-48cc-4691-86d8-5ecde93ba072", "27429fcf-9350-4772-b201-3ebd43f684e4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ff9057a4-a7a9-4f89-a7cd-40579b3df645", 0, "275239f5-28bb-44d4-b38a-dc43a0e945bc", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEIkr5F/QPsyDp3XFKIgqm4HbDKGG8ubjYIfg0knJHhQzdKw8a/cnB8giKUnbEL8sgw==", null, false, "6c884949-24bb-4677-b856-666554714545", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "ff9057a4-a7a9-4f89-a7cd-40579b3df645", "989d1c66-48f0-46dd-8a8f-19cbf6fcd304" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8735557d-48cc-4691-86d8-5ecde93ba072");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ff9057a4-a7a9-4f89-a7cd-40579b3df645", "989d1c66-48f0-46dd-8a8f-19cbf6fcd304" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "989d1c66-48f0-46dd-8a8f-19cbf6fcd304");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff9057a4-a7a9-4f89-a7cd-40579b3df645");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84bd5899-a34c-4d18-94a5-06c89baaad3f", "ac93d8e4-6bae-4116-99ac-018b735d2a70", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "056c1012-2def-4cfa-a683-44167a0d9d1e", 0, "374fc371-3d2b-4f78-89b2-6e891bc86be4", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAELCIUD6e0hz+AbBc6Xvf9zWkgP3hf+eUNLOzGio654IPTpPwHTQ0az23plP7wltyIg==", null, false, "8edc55dc-2fcc-4255-827c-c497ce1631a8", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "056c1012-2def-4cfa-a683-44167a0d9d1e", "84bd5899-a34c-4d18-94a5-06c89baaad3f" });
        }
    }
}
