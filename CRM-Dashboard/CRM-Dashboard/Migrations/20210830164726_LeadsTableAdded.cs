using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM_Dashboard.Migrations
{
    public partial class LeadsTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LeadStatus",
                table: "Leads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeetingType",
                table: "Leads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "Leads",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "Leads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Leads",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeadStatus",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "MeetingType",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Reference",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Leads");
        }
    }
}
