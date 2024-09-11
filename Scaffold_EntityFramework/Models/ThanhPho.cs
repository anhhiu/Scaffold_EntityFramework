using System;
using System.Collections.Generic;

namespace Scaffold_EntityFramework.Models;

public partial class ThanhPho
{
    public string Thanhpho { get; set; } = null!;

    public string? Tenthanhpho { get; set; }

    public virtual ICollection<KhachHang> KhachHangs { get; set; } = new List<KhachHang>();
}
