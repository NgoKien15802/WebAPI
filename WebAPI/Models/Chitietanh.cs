﻿using System;
using System.Collections.Generic;

namespace WebAPI.Models;

public partial class Chitietanh
{
    public string MaSp { get; set; } = null!;

    public string TenFileAnh { get; set; } = null!;

    public virtual Sanpham MaSpNavigation { get; set; } = null!;
}
