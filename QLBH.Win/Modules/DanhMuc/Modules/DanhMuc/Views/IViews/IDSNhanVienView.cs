using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface IDSNhanVienView:IBaseView<IDSNhanVienController>
    {
        DMNhanVienInfo NhanVienInfor { get; set; }
        object DataSource { get; set; }
        object ItemRowHanle { get;  }
        string MaNhanVien { get; }
        string TenNhanVien { get; }
        int IdPhongBan { get;  }
        object PhongBanDataSource {  set; }
        int IdChucVu { get;  }
        object ChucVuDataSource { set; }
        // hàm dùng refresh DataGrid
        void RefreshDataSource();
    }
}
