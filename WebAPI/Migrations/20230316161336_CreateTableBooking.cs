using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "trang_thai",
                table: "tbl_phong",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "so_giuong",
                table: "tbl_phong",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "loai_phong",
                table: "tbl_phong",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "danh_gia",
                table: "tbl_phong",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "tbl_khach_hang",
                columns: table => new
                {
                    ma_khach_hang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten_khach_hang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gioi_tinh = table.Column<bool>(type: "bit", nullable: false),
                    dia_chi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    so_dien_thoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    so_dinh_danh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_khach_hang", x => x.ma_khach_hang);
                });

            migrationBuilder.CreateTable(
                name: "tbl_dat_phong",
                columns: table => new
                {
                    ma_dat_phong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHangma_khach_hang = table.Column<int>(type: "int", nullable: false),
                    ma_khach_hang = table.Column<int>(type: "int", nullable: false),
                    Phongma_phong = table.Column<int>(type: "int", nullable: false),
                    ma_phong = table.Column<int>(type: "int", nullable: false),
                    ngay_nhan_phong = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ngay_tra_phong = table.Column<DateTime>(type: "datetime2", nullable: false),
                    so_luong_nguoi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_dat_phong", x => x.ma_dat_phong);
                    table.ForeignKey(
                        name: "FK_tbl_dat_phong_tbl_khach_hang_KhachHangma_khach_hang",
                        column: x => x.KhachHangma_khach_hang,
                        principalTable: "tbl_khach_hang",
                        principalColumn: "ma_khach_hang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_dat_phong_tbl_phong_Phongma_phong",
                        column: x => x.Phongma_phong,
                        principalTable: "tbl_phong",
                        principalColumn: "ma_phong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_dat_phong_KhachHangma_khach_hang",
                table: "tbl_dat_phong",
                column: "KhachHangma_khach_hang");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_dat_phong_Phongma_phong",
                table: "tbl_dat_phong",
                column: "Phongma_phong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_dat_phong");

            migrationBuilder.DropTable(
                name: "tbl_khach_hang");

            migrationBuilder.AlterColumn<string>(
                name: "trang_thai",
                table: "tbl_phong",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "so_giuong",
                table: "tbl_phong",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "loai_phong",
                table: "tbl_phong",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "danh_gia",
                table: "tbl_phong",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
