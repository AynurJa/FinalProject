using Microsoft.EntityFrameworkCore.Migrations;

namespace MagicHome.Migrations
{
    public partial class InitialNewLike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Likes_AdvertId",
                table: "Likes",
                column: "AdvertId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Adverts_AdvertId",
                table: "Likes",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Adverts_AdvertId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_AdvertId",
                table: "Likes");
        }
    }
}
