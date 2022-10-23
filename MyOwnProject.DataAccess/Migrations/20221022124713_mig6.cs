using Microsoft.EntityFrameworkCore.Migrations;

namespace MyOwnProject.DataAccess.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubtitleAndDate",
                table: "ExperienceTwos");

            migrationBuilder.DropColumn(
                name: "SubtitleAndDate",
                table: "Experiences");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "ExperienceTwos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "ExperienceTwos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Experiences",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subtitle",
                table: "Experiences",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "ExperienceTwos");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "ExperienceTwos");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "Subtitle",
                table: "Experiences");

            migrationBuilder.AddColumn<string>(
                name: "SubtitleAndDate",
                table: "ExperienceTwos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleAndDate",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
