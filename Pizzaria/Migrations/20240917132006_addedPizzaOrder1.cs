using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizzaria.Migrations
{
    public partial class addedPizzaOrder1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "BasePrice",
                table: "PizzaOrders",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BasePrice",
                table: "PizzaOrders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
