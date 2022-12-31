using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperSevens2023.Data.Migrations
{
    public partial class RemoveTwoFactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "AspNetUsers");
        }
    }
}
