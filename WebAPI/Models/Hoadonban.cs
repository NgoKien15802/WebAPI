﻿using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class Hoadonban
{
    public string SoHdb { get; set; } = null!;

    public string MaNv { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public DateTime NgayBan { get; set; }

    public decimal? TongTien { get; set; }

    public virtual Nhanvien MaNvNavigation { get; set; } = null!;

    public virtual Userinfo User { get; set; } = null!;
}
