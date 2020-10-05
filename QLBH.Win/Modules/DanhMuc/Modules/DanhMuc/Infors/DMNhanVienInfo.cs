using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMNhanVienInfo
    {
        [DefaultDisplay(false)]
        public int IdNhanVien { get; set; }
        [CaptionColumn("Mã nhân viên")]
        public string MaNhanVien { get; set; }
        [CaptionColumn("Tên nhân viên")]
        public string HoTen { get; set; }
        [CaptionColumn("Ngày sinh")]
        public DateTime NgaySinh { get; set; }
        [CaptionColumn("Giới tính")]
        public int GioiTinh { get; set; }
        [DefaultDisplay(false)]
        public int IdPhongBan { get; set; }
        [DefaultDisplay(false)]
        public int IdChucVu { get; set; }
        [CaptionColumn("Địa chỉ")]
        public string DiaChi { get; set; }
        [CaptionColumn("Điện thoại")]
        public string DienThoai { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }

        public string Email { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Id Trung tâm hạch toán")]
        public int IdTrungTamHachToan { get; set; }
        [DefaultDisplay(false)]
        [CaptionColumn("Id Người quản lý trực tiếp")]
        public int IdQuanLyTrucTiep { get; set; }
        [CaptionColumn("Phòng ban")]
        public string TenPhongBan { get; set; }
        [CaptionColumn("Chức vụ")]
        public string TenChucVu { get; set; }
        [CaptionColumn("Người quản lý trực tiếp")]
        public string QuanLyTrucTiep { get; set; }
        [DefaultDisplay(false)]
        public int PhuTrachCSKH { get; set; }
        public string MaVach { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is DMNhanVienInfo && (IdNhanVien == ((DMNhanVienInfo) obj).IdNhanVien ||
                MaNhanVien == ((DMNhanVienInfo) obj).MaNhanVien);
        }
    }
}
