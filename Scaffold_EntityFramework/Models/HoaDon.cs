using System;
using System.Collections.Generic;

namespace Scaffold_EntityFramework.Models;

public partial class HoaDon
{
    public string MaHd { get; set; } = null!;

    public string? MaKh { get; set; }

    public string? MaNv { get; set; }

    public DateTime? NgaylapHd { get; set; }

    public DateTime? Ngaynhanhang { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KhachHang? MaKhNavigation { get; set; }

    public virtual NhanVien? MaNvNavigation { get; set; }
}
