using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBookingPortal.Data.Migrations
{
    public partial class CorectReviewTBP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewTBPs_Companies_CompanyId",
                table: "ReviewTBPs");

            migrationBuilder.DropIndex(
                name: "IX_ReviewTBPs_CompanyId",
                table: "ReviewTBPs");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "ReviewTBPs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "ReviewTBPs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ReviewTBPs_CompanyId",
                table: "ReviewTBPs",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewTBPs_Companies_CompanyId",
                table: "ReviewTBPs",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
