using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Data;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
 public interface ICTDoiTuongView:IBaseView<ICTDoiTuongController>
 {
      DMDoiTuongInfo dmDoiTuongInfo { get; set; }
         int IdDoiTuong { get; set; }
        int IdCha { get; set; }
        string MaDoiTuong { get; set; }

        
        string TenDoiTuong { get; set; }

        
        string NguoiLienLac { get; set; }

        
        string DiaChi { get; set; }

        
       string DienThoai { get; set; }

        string Fax { get; set; }
        string Email { get; set; }

        
       string MaSoThue { get; set; }
        /// <summary>
        /// Type: Khách hàng = 0, Đại lý = 1, Đối tác = 2
        /// </summary>
        
       int Type { get; set; }

       
        int SuDung { get; set; }

        
        string GhiChu { get; set; }

        
        int GioiTinh { get; set; }
        List<LookUpInfor> objGT {  set; }

       
       DateTime NgaySinh { get; set; }

        
       int IdOrderType { get; set; }

        
       string MaRieng { get; set; }

        
      string SoCMND { get; set; }

       
      int IdLoaiDoiTuong { get; set; }
      object LoaiDoiTuongDataSource {  set; }

        
      string ChuDoanhNghiep { get; set; }

        
      string CMND_NLL { get; set; }

       
      string DienThoai_CDN { get; set; }

        
      string DienThoai_NLL { get; set; }

        
       int DoTuoi { get; set; }

        
       string Email_CDN { get; set; }

        
       double GiaTriMuaHang { get; set; }

        
       double HanMucTinDung { get; set; }

        
       double HanMucTDConLai { get; set; }

        
       double CongNoKhachHang { get; set; }

       int HanTra { get; set; }

       
       string Huyen { get; set; }

        
       string Biet_Ta_Tu { get; set; }

        
       int IdLoaiThe { get; set; }

       
       string NganHang { get; set; }

        
        DateTime NgayCapThe { get; set; }

        
       string NgheNghiep { get; set; }

        
       string PhongBan { get; set; }

        
        string QuocGia { get; set; }

        
        string SoDKKD { get; set; }

        
        int SoLanMuaHang { get; set; }

        
        string SiteNumber { get; set; }

        
       string MaVung { get; set; }

        
       string TaiKhoan { get; set; }

       
      int ThuNhap { get; set; }

        
      string Tinh { get; set; }

        
      double TyLePhat { get; set; }

        
       string WebSite { get; set; }

        
      int BillTo { get; set; }

        
       int ShipTo { get; set; }
       object DataSource { get; set; }
    }
}
