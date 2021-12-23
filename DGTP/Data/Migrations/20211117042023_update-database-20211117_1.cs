using Microsoft.EntityFrameworkCore.Migrations;

namespace DGTP.Data.Migrations
{
    public partial class updatedatabase20211117_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryAlias",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryAlias",
                table: "Products");
        }
    }
}
