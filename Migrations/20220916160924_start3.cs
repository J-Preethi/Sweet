using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineSweetShopy.Migrations
{
    public partial class start3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "paymentmode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "paymentmode",
                table: "Orders");
        }
    }
}
