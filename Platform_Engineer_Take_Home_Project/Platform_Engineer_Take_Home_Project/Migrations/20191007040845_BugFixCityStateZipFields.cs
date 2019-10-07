using Microsoft.EntityFrameworkCore.Migrations;

namespace Platform_Engineer_Take_Home_Project.Migrations
{
    public partial class BugFixCityStateZipFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
