﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scaffold_EntityFramework.Models;

#nullable disable

namespace Scaffold_EntityFramework.Migrations
{
    [DbContext(typeof(dbcontext))]
    [Migration("20240911041756_v0")]
    partial class v0
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Scaffold_EntityFramework.Models.ChiTietHoaDon", b =>
                {
                    b.Property<string>("MaHd")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("maHD")
                        .IsFixedLength();

                    b.Property<string>("MaSp")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("maSP")
                        .IsFixedLength();

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("soLuong");

                    b.HasKey("MaHd", "MaSp")
                        .HasName("PK__ChiTietH__CD9C332109EBBDA9");

                    b.HasIndex("MaSp");

                    b.ToTable("ChiTietHoaDon", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.HoaDon", b =>
                {
                    b.Property<string>("MaHd")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("maHD")
                        .IsFixedLength();

                    b.Property<string>("MaKh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("maKH")
                        .IsFixedLength();

                    b.Property<string>("MaNv")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("maNV")
                        .IsFixedLength();

                    b.Property<DateTime?>("NgaylapHd")
                        .HasColumnType("datetime")
                        .HasColumnName("ngaylapHD");

                    b.Property<DateTime?>("Ngaynhanhang")
                        .HasColumnType("datetime")
                        .HasColumnName("ngaynhanhang");

                    b.HasKey("MaHd")
                        .HasName("PK_HoaDon_New");

                    b.HasIndex("MaKh");

                    b.HasIndex("MaNv");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.KhachHang", b =>
                {
                    b.Property<string>("MaKh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("maKH")
                        .IsFixedLength();

                    b.Property<string>("Diachi")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("diachi");

                    b.Property<string>("Sdt")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("sdt")
                        .IsFixedLength();

                    b.Property<string>("TenCty")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenCTY");

                    b.Property<string>("TenKh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenKH");

                    b.Property<string>("Thanhpho")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("thanhpho")
                        .IsFixedLength();

                    b.HasKey("MaKh");

                    b.HasIndex("Thanhpho");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.NhanVien", b =>
                {
                    b.Property<string>("MaNv")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("maNV")
                        .IsFixedLength();

                    b.Property<string>("Diachi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("diachi");

                    b.Property<string>("Gioitinh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("gioitinh")
                        .IsFixedLength();

                    b.Property<string>("Hinh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("hinh")
                        .IsFixedLength();

                    b.Property<string>("Sdt")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("sdt")
                        .IsFixedLength();

                    b.Property<string>("TenNv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenNV");

                    b.HasKey("MaNv");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.SanPham", b =>
                {
                    b.Property<string>("MaSp")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("maSP")
                        .IsFixedLength();

                    b.Property<double?>("Dongia")
                        .HasColumnType("float")
                        .HasColumnName("dongia");

                    b.Property<string>("Donvitinh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("donvitinh")
                        .IsFixedLength();

                    b.Property<string>("Hinh")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("hinh")
                        .IsFixedLength();

                    b.Property<string>("TenSp")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenSP");

                    b.HasKey("MaSp");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.ThanhPho", b =>
                {
                    b.Property<string>("Thanhpho1")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("thanhpho")
                        .IsFixedLength();

                    b.Property<string>("Tenthanhpho")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("tenthanhpho")
                        .IsFixedLength();

                    b.HasKey("Thanhpho1");

                    b.ToTable("ThanhPho", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.ChiTietHoaDon", b =>
                {
                    b.HasOne("Scaffold_EntityFramework.Models.HoaDon", "MaHdNavigation")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("MaHd")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietHoaDon_HoaDon");

                    b.HasOne("Scaffold_EntityFramework.Models.SanPham", "MaSpNavigation")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("MaSp")
                        .IsRequired()
                        .HasConstraintName("FK_ChiTietHoaDon_SanPham");

                    b.Navigation("MaHdNavigation");

                    b.Navigation("MaSpNavigation");
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.HoaDon", b =>
                {
                    b.HasOne("Scaffold_EntityFramework.Models.KhachHang", "MaKhNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaKh")
                        .HasConstraintName("FK_HoaDon_KhachHang");

                    b.HasOne("Scaffold_EntityFramework.Models.NhanVien", "MaNvNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaNv")
                        .HasConstraintName("FK_HoaDon_NhanVien");

                    b.Navigation("MaKhNavigation");

                    b.Navigation("MaNvNavigation");
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.KhachHang", b =>
                {
                    b.HasOne("Scaffold_EntityFramework.Models.ThanhPho", "ThanhphoNavigation")
                        .WithMany("KhachHangs")
                        .HasForeignKey("Thanhpho")
                        .HasConstraintName("FK_KhachHang_ThanhPho");

                    b.Navigation("ThanhphoNavigation");
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.HoaDon", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.SanPham", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("Scaffold_EntityFramework.Models.ThanhPho", b =>
                {
                    b.Navigation("KhachHangs");
                });
#pragma warning restore 612, 618
        }
    }
}