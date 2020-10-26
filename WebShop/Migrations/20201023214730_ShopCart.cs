using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.Migrations
{
    public partial class ShopCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shopStaffItems",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    staffid = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    shopStaffIf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shopStaffItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_shopStaffItems_Staff_staffid",
                        column: x => x.staffid,
                        principalTable: "Staff",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_shopStaffItems_staffid",
                table: "shopStaffItems",
                column: "staffid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shopStaffItems");
        }
    }
}
