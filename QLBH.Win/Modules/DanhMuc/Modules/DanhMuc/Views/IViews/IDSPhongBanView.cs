using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface IDSPhongBanView:IBaseView<IDSPhongBanController>
    {
        object DataSource { get; set; }
        object ItemRowHanle { get; }
        string MaPhongBan { get; set; }
        string TenPhongBan { get; set; }
        void RefreshDataSource();

    }
}
