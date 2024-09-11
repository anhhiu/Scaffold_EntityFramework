using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Scaffold_EntityFramework.Models;

public partial class dbcontext : DbContext
{
    public dbcontext()
    {
    }

    public dbcontext(DbContextOptions<dbcontext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<ThanhPho> ThanhPhos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-7CAHEI3Q\\HATHANHHAO;Initial Catalog=QuanLyBanHang;Integrated Security=True;Encrypt=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietHoaDon>(entity =>
        {
            entity.HasKey(e => new { e.MaHd, e.MaSp }).HasName("PK__ChiTietH__CD9C332109EBBDA9");

            entity.ToTable("ChiTietHoaDon");

            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("maHD");
            entity.Property(e => e.MaSp)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("maSP");
            entity.Property(e => e.SoLuong).HasColumnName("soLuong");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.ChiTietHoaDons)
                .HasForeignKey(d => d.MaHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietHoaDon_HoaDon");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietHoaDons)
                .HasForeignKey(d => d.MaSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChiTietHoaDon_SanPham");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK_HoaDon_New");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("maHD");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("maKH");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("maNV");
            entity.Property(e => e.NgaylapHd)
                .HasColumnType("datetime")
                .HasColumnName("ngaylapHD");
            entity.Property(e => e.Ngaynhanhang)
                .HasColumnType("datetime")
                .HasColumnName("ngaynhanhang");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK_HoaDon_KhachHang");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK_HoaDon_NhanVien");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh);

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("maKH");
            entity.Property(e => e.Diachi).HasColumnName("diachi");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("sdt");
            entity.Property(e => e.TenCty)
                .HasMaxLength(50)
                .HasColumnName("tenCTY");
            entity.Property(e => e.TenKh)
                .HasMaxLength(50)
                .HasColumnName("tenKH");
            entity.Property(e => e.Thanhpho)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("thanhpho");

            entity.HasOne(d => d.ThanhphoNavigation).WithMany(p => p.KhachHangs)
                .HasForeignKey(d => d.Thanhpho)
                .HasConstraintName("FK_KhachHang_ThanhPho");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv);

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("maNV");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("diachi");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("gioitinh");
            entity.Property(e => e.Hinh)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("hinh");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("sdt");
            entity.Property(e => e.TenNv)
                .HasMaxLength(50)
                .HasColumnName("tenNV");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSp);

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSp)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("maSP");
            entity.Property(e => e.Dongia).HasColumnName("dongia");
            entity.Property(e => e.Donvitinh)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("donvitinh");
            entity.Property(e => e.Hinh)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("hinh");
            entity.Property(e => e.TenSp)
                .HasMaxLength(50)
                .HasColumnName("tenSP");
        });

        modelBuilder.Entity<ThanhPho>(entity =>
        {
            entity.HasKey(e => e.Thanhpho);

            entity.ToTable("ThanhPho");

            entity.Property(e => e.Thanhpho)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("thanhpho");
            entity.Property(e => e.Tenthanhpho)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("tenthanhpho");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
