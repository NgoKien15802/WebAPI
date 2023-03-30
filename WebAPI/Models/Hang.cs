using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class Hang
{
    public string MaHangSx { get; set; } = null!;

    public string TenHangSx { get; set; } = null!;

    public virtual ICollection<Sanpham> Sanphams { get; } = new List<Sanpham>();
}
