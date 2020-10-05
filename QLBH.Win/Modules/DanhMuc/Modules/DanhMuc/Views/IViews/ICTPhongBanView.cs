using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTPhongBanView:IBaseView<ICTPhongBanController>
    {
        int Id { get; set; }
        string MaPhongBan { get; set; }
        string TenPhongBan { get; set; }
        string GhiChu { get; set; }
        int SuDung { get; set; }
        // đối tượng gán dữ liệu 
        DMPhongBanInfor PhongBanInfor { get; set; }
    }
}
