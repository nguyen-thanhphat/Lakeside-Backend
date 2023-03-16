using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableBill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_hoa_don",
                columns: table => new
                {
                    ma_hoa_don = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatPhongma_dat_phong = table.Column<int>(type: "int", nullable: false),
                    ma_dat_phong = table.Column<int>(type: "int", nullable: false),
                    tong_tien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ngay_thanh_toan = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_hoa_don", x => x.ma_hoa_don);
                    table.ForeignKey(
                        name: "FK_tbl_hoa_don_tbl_dat_phong_DatPhongma_dat_phong",
                        column: x => x.DatPhongma_dat_phong,
                        principalTable: "tbl_dat_phong",
                        principalColumn: "ma_dat_phong",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_hoa_don_DatPhongma_dat_phong",
                table: "tbl_hoa_don",
                column: "DatPhongma_dat_phong");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_hoa_don");
        }
    }
}
