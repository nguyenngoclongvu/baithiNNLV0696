using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nguyenngoclongvu0696.Migrations
{
    /// <inheritdoc />
    public partial class nnlvcau3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nnlvcau3",
                columns: table => new
                {
                    HoTen = table.Column<string>(type: "TEXT", nullable: false),
                    LopHoc = table.Column<string>(type: "TEXT", nullable: false),
                    SoDienThoai = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nnlvcau3", x => x.HoTen);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nnlvcau3");
        }
    }
}
