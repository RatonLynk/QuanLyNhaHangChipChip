using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanVien",
                table: "HoaDon");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_NhanVien_TempId",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "NhanVien");

            migrationBuilder.AlterColumn<int>(
                name: "IDtable",
                table: "HoaDon",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IDNhanVien",
                table: "HoaDon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "HoaDon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DichVu",
                table: "HoaDon",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "HoaDon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SoDT",
                table: "HoaDon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanVien",
                table: "HoaDon",
                column: "IDNhanVien",
                principalTable: "NhanVien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanVien",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "DichVu",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "SoDT",
                table: "HoaDon");

            migrationBuilder.AddColumn<string>(
                name: "TempId",
                table: "NhanVien",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "IDtable",
                table: "HoaDon",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IDNhanVien",
                table: "HoaDon",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_NhanVien_TempId",
                table: "NhanVien",
                column: "TempId");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanVien",
                table: "HoaDon",
                column: "IDNhanVien",
                principalTable: "NhanVien",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
