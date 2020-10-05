using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface ICTTrungTamView:IBaseView<ICTTrungTamController>
    {
        DMTrungTamInfor DMTrungTamInfo { get; set; }
        int IdTrungTam { get; set; }
        string MaTrungTam { get; set; }
        string TenTrungTam { get; set; }
        string DiaChi { get; set; }
        string DienThoai { get; set; }
        string Fax { get; set; }
        string Email { get; set; }
        string GhiChu { get; set; }
        int SuDung { get; set; }
        int IdBangGia { get; set; }
        int Price_List_Id { get; set; }
        string ViTri { get; set; }
        string Duong { get; set; }
        string Tinh { get; set; }
        string QuocGia { get; set; }
        string ChannelCode { get; set; }
    }
}
