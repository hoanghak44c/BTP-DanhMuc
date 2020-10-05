using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMDoiTuongInfo
    {
        [DefaultDisplay(false)]
        public int IdDoiTuong { get; set; }

        [DefaultDisplay(false)]
        public int IdCha { get; set; }

        [CaptionColumn("Mã đối tượng")]
        public string MaDoiTuong { get; set; }

        [CaptionColumn("Tên đối tượng")]
        public string TenDoiTuong { get; set; }

        [CaptionColumn("Người liên lạc")]
        public string NguoiLienLac { get; set; }

        [CaptionColumn("Địa chỉ")]
        public string DiaChi { get; set; }

        [CaptionColumn("Điện thoại")]
        public string DienThoai { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        [CaptionColumn("Mã số thuế")]
        public string MaSoThue { get; set; }
        /// <summary>
        /// Type: Khách hàng = 0, Đại lý = 1, Đối tác = 2
        /// </summary>
        [DefaultDisplay(false)]
        public int Type { get; set; }

        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }

        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }

        [CaptionColumn("Giới tính")]
        public int GioiTinh { get; set; }

        [CaptionColumn("Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        [DefaultDisplay(false)]
        public int IdOrderType { get; set; }

        [DefaultDisplay(false), CaptionColumn("Mã riêng")]
        public string MaRieng { get; set; }

        [CaptionColumn("Số CMT")]
        public string SoCMND { get; set; }

        [DefaultDisplay(false)]
        public int IdLoaiDoiTuong { get; set; }
        
        [CaptionColumn("Chủ doanh nghiệp")]
        public string ChuDoanhNghiep { get; set; }

        [DefaultDisplay(false)]
        public string CMND_NLL { get; set; }

        [DefaultDisplay(false)]
        public string DienThoai_CDN { get; set; }

        [DefaultDisplay(false)]
        public string DienThoai_NLL { get; set; }

        [DefaultDisplay(false)]
        public int DoTuoi { get; set; }

        [DefaultDisplay(false)]
        public string Email_CDN { get; set; }

        [DefaultDisplay(false), CaptionColumn("Giá trị mua hàng")]
        public double GiaTriMuaHang { get; set; }

        [DefaultDisplay(true), CaptionColumn("Hạn mức tín dụng")]
        public double HanMucTinDung { get; set; }

        [DefaultDisplay(true), CaptionColumn("Hạn mức tín dụng còn lại")]
        public double HanMucTDConLai { get; set; }

        [DefaultDisplay(true), CaptionColumn("Công nợ khách hàng")]
        public double CongNoKhachHang { get; set; }

        [DefaultDisplay(false), CaptionColumn("Hạn trả")]
        public int HanTra { get; set; }
        
        [CaptionColumn("Huyện")]
        public string Huyen { get; set; }

        [DefaultDisplay(false), CaptionColumn("Biết Trần Anh từ")]
        public string Biet_Ta_Tu { get; set; }

        [DefaultDisplay(false)]
        public int IdLoaiThe { get; set; }

        [DefaultDisplay(false), CaptionColumn("Ngân hàng")]
        public string NganHang { get; set; }

        [DefaultDisplay(false), CaptionColumn("Ngày cấp thẻ")]
        public DateTime NgayCapThe { get; set; }

        [DefaultDisplay(false), CaptionColumn("Nghề nghiệp")]
        public string NgheNghiep { get; set; }

        [DefaultDisplay(false), CaptionColumn("Phòng ban")]
        public string PhongBan { get; set; }

        [DefaultDisplay(false), CaptionColumn("Quốc gia")]
        public string QuocGia { get; set; }

        [DefaultDisplay(false), CaptionColumn("Số ĐKKD")]
        public string SoDKKD { get; set; }

        [DefaultDisplay(false), CaptionColumn("Số lần mua hàng")]
        public int SoLanMuaHang { get; set; }

        [DefaultDisplay(false)]
        public string SiteNumber { get; set; }

        [DefaultDisplay(false), CaptionColumn("Mã vùng")]
        public string MaVung { get; set; }

        [DefaultDisplay(false), CaptionColumn("Tài khoản")]
        public string TaiKhoan { get; set; }

        [DefaultDisplay(false), CaptionColumn("Thu nhập")]
        public int ThuNhap { get; set; }

        [DefaultDisplay(false), CaptionColumn("Tỉnh")]
        public string Tinh { get; set; }

        [DefaultDisplay(false), CaptionColumn("Tỷ lệ phạt")]
        public double TyLePhat { get; set; }

        [DefaultDisplay(false)]
        public string WebSite { get; set; }

        [DefaultDisplay(false)]
        public int BillTo { get; set; }
        
        [DefaultDisplay(false)]
        public int ShipTo { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is DMDoiTuongInfo && (IdDoiTuong == ((DMDoiTuongInfo)obj).IdDoiTuong ||
                MaDoiTuong == ((DMDoiTuongInfo)obj).MaDoiTuong);
        }
    }
}
