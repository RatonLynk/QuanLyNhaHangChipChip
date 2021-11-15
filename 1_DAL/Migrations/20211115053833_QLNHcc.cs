using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL.Migrations
{
    public partial class QLNHcc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_Role",
                table: "NhanVien",
                column: "Role");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_Roles",
                table: "NhanVien",
                column: "Role",
                principalTable: "Roles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_Roles",
                table: "NhanVien");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_Role",
                table: "NhanVien");
        }
    }
}
