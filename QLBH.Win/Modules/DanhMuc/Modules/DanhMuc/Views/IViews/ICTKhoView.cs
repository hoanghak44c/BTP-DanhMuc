using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTKhoView:IBaseView<ICTKhoController>
    {
        DMKhoInfo dmKhoInfo { get; set; }
        int IdKho { get; set; }
        int IdTrungTam { get; }
        string MaKho { get; set; }
        string TenKho { get; set; }
        string DiaChi { get; set; }
        string DienThoai { get; set; }
        string Fax { get; set; }
        string Email { get; set; }
        string GhiChu { get; set; }
        int SuDung { get; set; }
        string MaKhoOracle { get; set; }
        string ViTri { get; set; }
        string Duong { get; set; }
        string Tinh { get; set; }
        string QuocGia { get; set; }
        int Type { get; set; }
        object TrungTamDataSource { get; set; }
        string  OtherTrungTam { get; set; }
        string MaVung { get; set; }
        object checkTrungTam { set; get; }
        // đối tượng đếm số id trung tâm
        int OtherTrungTamCount { get; }
        // đối tượng lấy ra các item đã check
        object CheckedOtherTrungTam(int index);
        // gán check cho những  item othertrungtam đã được tách từ chuỗi othertrungtam 
        void othertrungtamcheck(int index);
        // load datasource trung tâm vào control
        object listcheckothertrungtam { get; set; }





    }
}
