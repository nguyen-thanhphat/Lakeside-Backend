using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableBookingDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DichVuDiKem",
                columns: table => new
                {
                    ma_dich_vu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_dich_vu = table.Column<int>(type: "int", nullable: false),
                    gia_dich_vu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    mo_ta_dich_vu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVuDiKem", x => x.ma_dich_vu);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDatPhong",
                columns: table => new
                {
                    ma_chi_tiet_dat_phong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatPhongma_dat_phong = table.Column<int>(type: "int", nullable: false),
                    ma_dat_phong = table.Column<int>(type: "int", nullable: false),
                    DichVuDiKemma_dich_vu = table.Column<int>(type: "int", nullable: false),
                    ma_dich_vu = table.Column<int>(type: "int", nullable: false),
                    so_luong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDatPhong", x => x.ma_chi_tiet_dat_phong);
                    table.ForeignKey(
                        name: "FK_ChiTietDatPhong_DichVuDiKem_DichVuDiKemma_dich_vu",
                        column: x => x.DichVuDiKemma_dich_vu,
                        principalTable: "DichVuDiKem",
                        principalColumn: "ma_dich_vu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDatPhong_tbl_dat_phong_DatPhongma_dat_phong",
                        column: x => x.DatPhongma_dat_phong,
                        principalTable: "tbl_dat_phong",
                        principalColumn: "ma_dat_phong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDatPhong_DatPhongma_dat_phong",
                table: "ChiTietDatPhong",
                column: "DatPhongma_dat_phong");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDatPhong_DichVuDiKemma_dich_vu",
                table: "ChiTietDatPhong",
                column: "DichVuDiKemma_dich_vu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDatPhong");

            migrationBuilder.DropTable(
                name: "DichVuDiKem");
        }
    }
}
