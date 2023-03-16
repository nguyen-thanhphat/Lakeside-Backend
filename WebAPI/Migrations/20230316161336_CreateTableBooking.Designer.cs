﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20230316161336_CreateTableBooking")]
    partial class CreateTableBooking
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPI.Models.DatPhong", b =>
                {
                    b.Property<int>("ma_dat_phong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ma_dat_phong"));

                    b.Property<int>("KhachHangma_khach_hang")
                        .HasColumnType("int");

                    b.Property<int>("Phongma_phong")
                        .HasColumnType("int");

                    b.Property<int>("ma_khach_hang")
                        .HasColumnType("int");

                    b.Property<int>("ma_phong")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngay_nhan_phong")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ngay_tra_phong")
                        .HasColumnType("datetime2");

                    b.Property<int>("so_luong_nguoi")
                        .HasColumnType("int");

                    b.HasKey("ma_dat_phong");

                    b.HasIndex("KhachHangma_khach_hang");

                    b.HasIndex("Phongma_phong");

                    b.ToTable("tbl_dat_phong");
                });

            modelBuilder.Entity("WebAPI.Models.KhachHang", b =>
                {
                    b.Property<int>("ma_khach_hang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ma_khach_hang"));

                    b.Property<string>("dia_chi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("gioi_tinh")
                        .HasColumnType("bit");

                    b.Property<string>("so_dien_thoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("so_dinh_danh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ten_khach_hang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ma_khach_hang");

                    b.ToTable("tbl_khach_hang");
                });

            modelBuilder.Entity("WebAPI.Models.Phong", b =>
                {
                    b.Property<int>("ma_phong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ma_phong"));

                    b.Property<string>("danh_gia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("gia_phong")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("loai_phong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("so_giuong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("so_luong_nguoi_toi_da")
                        .HasColumnType("int");

                    b.Property<string>("trang_thai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ma_phong");

                    b.ToTable("tbl_phong");
                });

            modelBuilder.Entity("WebAPI.Models.DatPhong", b =>
                {
                    b.HasOne("WebAPI.Models.KhachHang", "KhachHang")
                        .WithMany("DatPhongs")
                        .HasForeignKey("KhachHangma_khach_hang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Phong", "Phong")
                        .WithMany("DatPhongs")
                        .HasForeignKey("Phongma_phong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("Phong");
                });

            modelBuilder.Entity("WebAPI.Models.KhachHang", b =>
                {
                    b.Navigation("DatPhongs");
                });

            modelBuilder.Entity("WebAPI.Models.Phong", b =>
                {
                    b.Navigation("DatPhongs");
                });
#pragma warning restore 612, 618
        }
    }
}
