using Microsoft.EntityFrameworkCore.Migrations;

namespace Platform_Engineer_Take_Home_Project.Migrations
{
    public partial class UpdateIpFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IProgress",
                table: "Users",
                newName: "IP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IP",
                table: "Users",
                newName: "IProgress");
        }
    }
}
