using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL.Migrations
{
    public partial class Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NguyenLieu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguyenLieu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CongThuc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMon = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    IdNguyenLieu = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongThuc", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CongThuc_MonAnChiTiet_IdMon",
                        column: x => x.IdMon,
                        principalTable: "MonAnChiTiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CongThuc_NguyenLieu_IdNguyenLieu",
                        column: x => x.IdNguyenLieu,
                        principalTable: "NguyenLieu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CongThuc_IdMon",
                table: "CongThuc",
                column: "IdMon");

            migrationBuilder.CreateIndex(
                name: "IX_CongThuc_IdNguyenLieu",
                table: "CongThuc",
                column: "IdNguyenLieu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CongThuc");

            migrationBuilder.DropTable(
                name: "NguyenLieu");
        }
    }
}
