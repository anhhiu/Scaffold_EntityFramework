using System;
using System.Collections.Generic;

namespace Scaffold_EntityFramework.Models;

public partial class ChiTietHoaDon
{
    public string MaHd { get; set; } = null!;

    public string MaSp { get; set; } = null!;

    public int? SoLuong { get; set; }

    public virtual HoaDon MaHdNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}
