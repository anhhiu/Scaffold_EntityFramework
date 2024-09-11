IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [NhanVien] (
    [maNV] nchar(10) NOT NULL,
    [tenNV] nvarchar(50) NULL,
    [gioitinh] nchar(10) NULL,
    [diachi] nvarchar(50) NULL,
    [sdt] nchar(10) NULL,
    [hinh] nchar(10) NULL,
    CONSTRAINT [PK_NhanVien] PRIMARY KEY ([maNV])
);
GO

CREATE TABLE [SanPham] (
    [maSP] nchar(10) NOT NULL,
    [tenSP] nvarchar(50) NULL,
    [donvitinh] nchar(10) NULL,
    [dongia] float NULL,
    [hinh] nchar(10) NULL,
    CONSTRAINT [PK_SanPham] PRIMARY KEY ([maSP])
);
GO

CREATE TABLE [ThanhPho] (
    [thanhpho] nchar(10) NOT NULL,
    [tenthanhpho] nchar(10) NULL,
    CONSTRAINT [PK_ThanhPho] PRIMARY KEY ([thanhpho])
);
GO

CREATE TABLE [KhachHang] (
    [maKH] nchar(10) NOT NULL,
    [tenKH] nvarchar(50) NULL,
    [tenCTY] nvarchar(50) NULL,
    [diachi] nvarchar(max) NULL,
    [thanhpho] nchar(10) NULL,
    [sdt] nchar(10) NULL,
    CONSTRAINT [PK_KhachHang] PRIMARY KEY ([maKH]),
    CONSTRAINT [FK_KhachHang_ThanhPho] FOREIGN KEY ([thanhpho]) REFERENCES [ThanhPho] ([thanhpho])
);
GO

CREATE TABLE [HoaDon] (
    [maHD] nchar(10) NOT NULL,
    [maKH] nchar(10) NULL,
    [maNV] nchar(10) NULL,
    [ngaylapHD] datetime NULL,
    [ngaynhanhang] datetime NULL,
    CONSTRAINT [PK_HoaDon_New] PRIMARY KEY ([maHD]),
    CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY ([maKH]) REFERENCES [KhachHang] ([maKH]),
    CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY ([maNV]) REFERENCES [NhanVien] ([maNV])
);
GO

CREATE TABLE [ChiTietHoaDon] (
    [maHD] nchar(10) NOT NULL,
    [maSP] nchar(10) NOT NULL,
    [soLuong] int NULL,
    CONSTRAINT [PK__ChiTietH__CD9C332109EBBDA9] PRIMARY KEY ([maHD], [maSP]),
    CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY ([maHD]) REFERENCES [HoaDon] ([maHD]),
    CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY ([maSP]) REFERENCES [SanPham] ([maSP])
);
GO

CREATE INDEX [IX_ChiTietHoaDon_maSP] ON [ChiTietHoaDon] ([maSP]);
GO

CREATE INDEX [IX_HoaDon_maKH] ON [HoaDon] ([maKH]);
GO

CREATE INDEX [IX_HoaDon_maNV] ON [HoaDon] ([maNV]);
GO

CREATE INDEX [IX_KhachHang_thanhpho] ON [KhachHang] ([thanhpho]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240911041756_v0', N'8.0.8');
GO

COMMIT;
GO

