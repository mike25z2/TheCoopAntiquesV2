using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCoopAntiquesV2.Data.Migrations
{
    public partial class BoothAndDealerBooth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 5, nullable: false),
                    Desctiption = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DealerBooth",
                columns: table => new
                {
                    DealerId = table.Column<int>(nullable: false),
                    BoothId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerBooth", x => new { x.DealerId, x.BoothId });
                    table.ForeignKey(
                        name: "FK_DealerBooth_Booth_BoothId",
                        column: x => x.BoothId,
                        principalTable: "Booth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DealerBooth_Dealer_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DealerBooth_BoothId",
                table: "DealerBooth",
                column: "BoothId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DealerBooth");

            migrationBuilder.DropTable(
                name: "Booth");
        }
    }
}
