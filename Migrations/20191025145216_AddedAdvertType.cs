using Microsoft.EntityFrameworkCore.Migrations;

namespace MagicHome.Migrations
{
    public partial class AddedAdvertType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SaleType",
                table: "AdvertTypes",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SaleType",
                table: "AdvertTypes",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
