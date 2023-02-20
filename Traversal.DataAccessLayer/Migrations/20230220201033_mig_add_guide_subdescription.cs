using Microsoft.EntityFrameworkCore.Migrations;

namespace Traversal.DataAccessLayer.Migrations
{
    public partial class mig_add_guide_subdescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubDescription",
                table: "Guides",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubDescription",
                table: "Guides");
        }
    }
}
