using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOwnProject.DataAccess.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "SocialMedias",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "SocialMedias",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "SocialMedias");
        }
    }
}
