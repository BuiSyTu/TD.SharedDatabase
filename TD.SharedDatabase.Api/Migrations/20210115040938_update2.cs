using Microsoft.EntityFrameworkCore.Migrations;

namespace TD.SharedDatabase.Api.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "namHoc",
                table: "LopHoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "namHoc",
                table: "HocSinh",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "namHoc",
                table: "GiaoVien",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "namHoc",
                table: "LopHoc");

            migrationBuilder.DropColumn(
                name: "namHoc",
                table: "HocSinh");

            migrationBuilder.DropColumn(
                name: "namHoc",
                table: "GiaoVien");
        }
    }
}
