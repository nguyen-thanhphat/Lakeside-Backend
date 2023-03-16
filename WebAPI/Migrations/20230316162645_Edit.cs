using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDatPhong_DichVuDiKem_DichVuDiKemma_dich_vu",
                table: "ChiTietDatPhong");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietDatPhong_tbl_dat_phong_DatPhongma_dat_phong",
                table: "ChiTietDatPhong");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DichVuDiKem",
                table: "DichVuDiKem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietDatPhong",
                table: "ChiTietDatPhong");

            migrationBuilder.RenameTable(
                name: "DichVuDiKem",
                newName: "tbl_dich_vu");

            migrationBuilder.RenameTable(
                name: "ChiTietDatPhong",
                newName: "tbl_chi_tiet_dat_phong");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDatPhong_DichVuDiKemma_dich_vu",
                table: "tbl_chi_tiet_dat_phong",
                newName: "IX_tbl_chi_tiet_dat_phong_DichVuDiKemma_dich_vu");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietDatPhong_DatPhongma_dat_phong",
                table: "tbl_chi_tiet_dat_phong",
                newName: "IX_tbl_chi_tiet_dat_phong_DatPhongma_dat_phong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_dich_vu",
                table: "tbl_dich_vu",
                column: "ma_dich_vu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_chi_tiet_dat_phong",
                table: "tbl_chi_tiet_dat_phong",
                column: "ma_chi_tiet_dat_phong");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_chi_tiet_dat_phong_tbl_dat_phong_DatPhongma_dat_phong",
                table: "tbl_chi_tiet_dat_phong",
                column: "DatPhongma_dat_phong",
                principalTable: "tbl_dat_phong",
                principalColumn: "ma_dat_phong",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_chi_tiet_dat_phong_tbl_dich_vu_DichVuDiKemma_dich_vu",
                table: "tbl_chi_tiet_dat_phong",
                column: "DichVuDiKemma_dich_vu",
                principalTable: "tbl_dich_vu",
                principalColumn: "ma_dich_vu",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_chi_tiet_dat_phong_tbl_dat_phong_DatPhongma_dat_phong",
                table: "tbl_chi_tiet_dat_phong");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_chi_tiet_dat_phong_tbl_dich_vu_DichVuDiKemma_dich_vu",
                table: "tbl_chi_tiet_dat_phong");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_dich_vu",
                table: "tbl_dich_vu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_chi_tiet_dat_phong",
                table: "tbl_chi_tiet_dat_phong");

            migrationBuilder.RenameTable(
                name: "tbl_dich_vu",
                newName: "DichVuDiKem");

            migrationBuilder.RenameTable(
                name: "tbl_chi_tiet_dat_phong",
                newName: "ChiTietDatPhong");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_chi_tiet_dat_phong_DichVuDiKemma_dich_vu",
                table: "ChiTietDatPhong",
                newName: "IX_ChiTietDatPhong_DichVuDiKemma_dich_vu");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_chi_tiet_dat_phong_DatPhongma_dat_phong",
                table: "ChiTietDatPhong",
                newName: "IX_ChiTietDatPhong_DatPhongma_dat_phong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DichVuDiKem",
                table: "DichVuDiKem",
                column: "ma_dich_vu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietDatPhong",
                table: "ChiTietDatPhong",
                column: "ma_chi_tiet_dat_phong");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDatPhong_DichVuDiKem_DichVuDiKemma_dich_vu",
                table: "ChiTietDatPhong",
                column: "DichVuDiKemma_dich_vu",
                principalTable: "DichVuDiKem",
                principalColumn: "ma_dich_vu",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietDatPhong_tbl_dat_phong_DatPhongma_dat_phong",
                table: "ChiTietDatPhong",
                column: "DatPhongma_dat_phong",
                principalTable: "tbl_dat_phong",
                principalColumn: "ma_dat_phong",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
