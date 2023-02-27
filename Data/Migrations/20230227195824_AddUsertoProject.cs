using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectsMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUsertoProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Projects",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_IdentityUserId",
                table: "Projects",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_IdentityUserId",
                table: "Projects",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_IdentityUserId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_IdentityUserId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Projects");
        }
    }
}
