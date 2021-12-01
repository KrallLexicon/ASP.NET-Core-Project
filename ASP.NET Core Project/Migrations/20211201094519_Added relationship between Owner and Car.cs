using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Project.Migrations
{
    public partial class AddedrelationshipbetweenOwnerandCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarOwners",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false),
                    OwnerId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarOwners", x => new { x.CarId, x.OwnerId });
                    table.ForeignKey(
                        name: "FK_CarOwners_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarOwners_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "SSN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarOwners",
                columns: new[] { "CarId", "OwnerId" },
                values: new object[,]
                {
                    { 1, "1234567980" },
                    { 2, "1234567980" },
                    { 3, "1234567980" },
                    { 1, "523423423" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarOwners_OwnerId",
                table: "CarOwners",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarOwners");
        }
    }
}
