using System;
using System.Collections.Generic;

namespace Scaffold_EntityFramework.Models;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;

    public string? TenNv { get; set; }

    public string? Gioitinh { get; set; }

    public string? Diachi { get; set; }

    public string? Sdt { get; set; }

    public string? Hinh { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
