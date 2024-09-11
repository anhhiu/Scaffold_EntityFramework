using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Scaffold_EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    maNV = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    tenNV = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    gioitinh = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    diachi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    sdt = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    hinh = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.maNV);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    maSP = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    tenSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    donvitinh = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    dongia = table.Column<double>(type: "float", nullable: true),
                    hinh = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.maSP);
                });

            migrationBuilder.CreateTable(
                name: "ThanhPho",
                columns: table => new
                {
                    thanhpho = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    tenthanhpho = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhPho", x => x.thanhpho);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    maKH = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    tenKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tenCTY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    diachi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    thanhpho = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    sdt = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.maKH);
                    table.ForeignKey(
                        name: "FK_KhachHang_ThanhPho",
                        column: x => x.thanhpho,
                        principalTable: "ThanhPho",
                        principalColumn: "thanhpho");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    maHD = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    maKH = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    maNV = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ngaylapHD = table.Column<DateTime>(type: "datetime", nullable: true),
                    ngaynhanhang = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon_New", x => x.maHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang",
                        column: x => x.maKH,
                        principalTable: "KhachHang",
                        principalColumn: "maKH");
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien",
                        column: x => x.maNV,
                        principalTable: "NhanVien",
                        principalColumn: "maNV");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDon",
                columns: table => new
                {
                    maHD = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    maSP = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    soLuong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChiTietH__CD9C332109EBBDA9", x => new { x.maHD, x.maSP });
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_HoaDon",
                        column: x => x.maHD,
                        principalTable: "HoaDon",
                        principalColumn: "maHD");
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDon_SanPham",
                        column: x => x.maSP,
                        principalTable: "SanPham",
                        principalColumn: "maSP");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_maSP",
                table: "ChiTietHoaDon",
                column: "maSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_maKH",
                table: "HoaDon",
                column: "maKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_maNV",
                table: "HoaDon",
                column: "maNV");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_thanhpho",
                table: "KhachHang",
                column: "thanhpho");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDon");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ThanhPho");
        }
    }
}
