using Microsoft.EntityFrameworkCore.Migrations;

namespace Platform_Engineer_Take_Home_Project.Migrations
{
    public partial class AddRentEstimatePriceField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "RentEstimated",
                table: "Users",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentEstimated",
                table: "Users");
        }
    }
}
