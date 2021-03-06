﻿using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface IDSLyDoTraHangView:IBaseView<IDSLyDoTraHangController>
    {
        object DataSource { get; set; }
        object ItemRowHanle { get; }
        string MaLyDo { get; }
        string LyDo { get; }
        void RefreshDataSource();
    }
}
