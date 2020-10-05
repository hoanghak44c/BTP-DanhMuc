using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
   public interface ICTNhanVienView:IBaseView<ICTNhanVienController>
   {
       DMNhanVienInfo NhanVienInfo { get; set; }
       int IdNhanVien { get; set; }
       string MaNhanVien { get; set; }
       string HoTen { get; set; }
       DateTime NgaySinh { get; set; }
       int GioiTinh { get; set; }
       int IdPhongBan { get; set; }
       object PhongBanDataSource {  set; }
       int IdChucVu { get; set; }
       object ChucVuDataSource { set; }
       string DiaChi { get; set; }
       string DienThoai { get; set; }
       int SuDung { get; set; }
       string Email { get; set; }
       string GhiChu { get; set; }
       int IdTrungTamHachToan { get; set; }
       // đối tượng list giới tính
       List<LookUpInfor> objGioiTinh {  set; }
       object DataSource {  set; }
       


    }
}
