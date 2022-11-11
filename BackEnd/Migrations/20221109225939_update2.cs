using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StdName",
                table: "Students",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "StdEmail",
                table: "Students",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Students",
                newName: "StdName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Students",
                newName: "StdEmail");
        }
    }
}
