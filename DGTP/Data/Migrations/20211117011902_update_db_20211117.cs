using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DGTP.Data.Migrations
{
    public partial class update_db_20211117 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    SEOName = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Details1 = table.Column<string>(nullable: true),
                    Details2 = table.Column<string>(nullable: true),
                    Details3 = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true),
                    Rate = table.Column<string>(nullable: true),
                    Introduction = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HTMLCode = table.Column<string>(nullable: true),
                    HTMLDisplay = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CraeteDate = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
