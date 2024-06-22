using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restoran.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OpeningDaysWeekEnd",
                table: "Footers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OpeningHoursInWeek",
                table: "Footers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpeningDaysWeekEnd",
                table: "Footers");

            migrationBuilder.DropColumn(
                name: "OpeningHoursInWeek",
                table: "Footers");
        }
    }
}
