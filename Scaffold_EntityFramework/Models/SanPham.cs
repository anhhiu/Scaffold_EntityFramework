using System;
using System.Collections.Generic;

namespace Scaffold_EntityFramework.Models;

public partial class SanPham
{
    public string MaSp { get; set; } = null!;

    public string? TenSp { get; set; }

    public string? Donvitinh { get; set; }

    public double? Dongia { get; set; }

    public string? Hinh { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
}
