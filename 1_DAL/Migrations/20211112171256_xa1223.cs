using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL.Migrations
{
    public partial class xa1223 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonAnChiTiet_CachCheBien",
                table: "MonAnChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_MonAnChiTiet_HoaDonChiTiet",
                table: "MonAnChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_MonAnChiTiet_ThucDon",
                table: "MonAnChiTiet");

            migrationBuilder.AddColumn<int>(
                name: "IDChiTiet",
                table: "ThucDon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CachCheBien",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "BanAn",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "TinhTrang",
                table: "BanAn",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ThucDon_IDChiTiet",
                table: "ThucDon",
                column: "IDChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IDFood",
                table: "HoaDonChiTiet",
                column: "IDFood");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiet_MonAnChiTiet",
                table: "HoaDonChiTiet",
                column: "IDFood",
                principalTable: "MonAnChiTiet",
                principalColumn: "MaMon",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonAnChiTiet_CachChebien",
                table: "MonAnChiTiet",
                column: "IDMethod",
                principalTable: "CachCheBien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ThucDon_MonAnChiTiet",
                table: "ThucDon",
                column: "IDChiTiet",
                principalTable: "MonAnChiTiet",
                principalColumn: "MaMon",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiet_MonAnChiTiet",
                table: "HoaDonChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_MonAnChiTiet_CachChebien",
                table: "MonAnChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_ThucDon_MonAnChiTiet",
                table: "ThucDon");

            migrationBuilder.DropIndex(
                name: "IX_ThucDon_IDChiTiet",
                table: "ThucDon");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonChiTiet_IDFood",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "IDChiTiet",
                table: "ThucDon");

            migrationBuilder.DropColumn(
                name: "TinhTrang",
                table: "BanAn");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CachCheBien",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "BanAn",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddForeignKey(
                name: "FK_MonAnChiTiet_CachCheBien",
                table: "MonAnChiTiet",
                column: "IDMethod",
                principalTable: "CachCheBien",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonAnChiTiet_HoaDonChiTiet",
                table: "MonAnChiTiet",
                column: "IDUnit",
                principalTable: "HoaDonChiTiet",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonAnChiTiet_ThucDon",
                table: "MonAnChiTiet",
                column: "MaMon",
                principalTable: "ThucDon",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
