using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface IDSChucVuView:IBaseView<IDSChucVuController>
    {
        object DataSource { get; set; }
        object ItemRowHanle { get; }
        string MaChucVu { get;  }
        string TenChucVu { get; }
        void RefreshDataSource();

    }
}
