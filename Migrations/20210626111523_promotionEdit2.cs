using Microsoft.EntityFrameworkCore.Migrations;

namespace app.Migrations
{
    public partial class promotionEdit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Promotions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Promotions",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Promotions");
        }
    }
}
