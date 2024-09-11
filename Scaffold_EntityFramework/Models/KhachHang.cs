using System;
using System.Collections.Generic;

namespace Scaffold_EntityFramework.Models;

public partial class KhachHang
{
    public string MaKh { get; set; } = null!;

    public string? TenKh { get; set; }

    public string? TenCty { get; set; }

    public string? Diachi { get; set; }

    public string? Thanhpho { get; set; }

    public string? Sdt { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ThanhPho? ThanhphoNavigation { get; set; }
}
