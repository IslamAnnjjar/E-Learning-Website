using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_User_user_id",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Admins_AdminID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Instructors_instructorInsId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_AdminID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_instructorInsId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Admins_user_id",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "SuperID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "instructorInsId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Admins");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_User_UserId",
                table: "Admins",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_User_UserId",
                table: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Admins_UserId",
                table: "Admins");

            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SuperID",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "instructorInsId",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_AdminID",
                table: "Instructors",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_instructorInsId",
                table: "Instructors",
                column: "instructorInsId");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_user_id",
                table: "Admins",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_User_user_id",
                table: "Admins",
                column: "user_id",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Admins_AdminID",
                table: "Instructors",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Instructors_instructorInsId",
                table: "Instructors",
                column: "instructorInsId",
                principalTable: "Instructors",
                principalColumn: "InsId");
        }
    }
}
