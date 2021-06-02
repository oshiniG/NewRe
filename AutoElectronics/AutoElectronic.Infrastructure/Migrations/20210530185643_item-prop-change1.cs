using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoElectronic.Infrastructure.Migrations
{
    public partial class itempropchange1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Item",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "UnitPrice",
                table: "Item",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
