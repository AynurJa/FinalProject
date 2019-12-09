using Microsoft.EntityFrameworkCore.Migrations;

namespace MagicHome.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_AdvertTypes_AdvertTypeId1",
                table: "Adverts");

            migrationBuilder.DropIndex(
                name: "IX_Adverts_AdvertTypeId1",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "AdvertTypeId1",
                table: "Adverts");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "firstname");

            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Adverts",
                newName: "AdvertTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "AspNetUsers",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_AdvertTypeId",
                table: "Adverts",
                column: "AdvertTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_AdvertTypes_AdvertTypeId",
                table: "Adverts",
                column: "AdvertTypeId",
                principalTable: "AdvertTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_AdvertTypes_AdvertTypeId",
                table: "Adverts");

            migrationBuilder.DropIndex(
                name: "IX_Adverts_AdvertTypeId",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstname",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "AdvertTypeId",
                table: "Adverts",
                newName: "MyProperty");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AddColumn<int>(
                name: "AdvertTypeId1",
                table: "Adverts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_AdvertTypeId1",
                table: "Adverts",
                column: "AdvertTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_AdvertTypes_AdvertTypeId1",
                table: "Adverts",
                column: "AdvertTypeId1",
                principalTable: "AdvertTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
