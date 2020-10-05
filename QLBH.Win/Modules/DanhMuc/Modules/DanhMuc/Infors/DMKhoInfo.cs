using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMKhoInfo
    {
        [DefaultDisplay(false)]
        public int IdKho { get; set; }
        /// <summary>
        /// Được dùng để đồng bộ
        /// </summary>
        [DefaultDisplay(false)]
        public int IdTrungTam { get; set; }
        /// <summary>
        /// Được dùng để đồng bộ
        /// </summary>
        [CaptionColumn("Mã kho")]
        public string MaKho { get; set; }
        /// <summary>
        /// Được dùng để đồng bộ
        /// </summary>
        [CaptionColumn("Tên kho")]
        public string TenKho { get; set; }
        [CaptionColumn("Địa chỉ")]
        public string DiaChi { get; set; }
        [CaptionColumn("Điện thoại")]
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        
        public string Email { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
        [DefaultDisplay(false), CaptionColumn("Ngày khóa sổ")]
        public DateTime NgayKhoaSo { get; set; }
        [DefaultDisplay(false), CaptionColumn("Ngày dư đầu")]
        public DateTime NgayDuDau { get; set; }
        [CaptionColumn("In hóa đơn")]
        public int InHoaDon { get; set; }
        [CaptionColumn("In phiếu xuất")]
        public int InPhieuXuat { get; set; }
        [CaptionColumn("Lần đồng bộ trước")]
        public DateTime LanDongBoTruoc { get; set; }
        [CaptionColumn("Mã vùng")]
        public string MaVung { get; set; }
        [DefaultDisplay(false)]
        public int IdKhachMacDinh { get; set; }
        [DefaultDisplay(false), CaptionColumn("Khóa nhập đầu kỳ")]
        public int KhoaNhapDauKy { get; set; }
        [DefaultDisplay(false), CaptionColumn("Trung tâm khác")]
        public string OtherTrungTam { get; set; }
        [DefaultDisplay(false), CaptionColumn("Mã kho ORC")]
        public string MaKhoOracle { get; set; }
        [CaptionColumn("Vị trí")]
        public string ViTri { get; set; }
        [CaptionColumn("Đường")]
        public string Duong { get; set; }
        [CaptionColumn("Tỉnh")]
        public string Tinh { get; set; }
        [CaptionColumn("Quốc gia")]
        public string QuocGia { get; set; }
        [DefaultDisplay(false)]
        public int Type { get; set; }
        public int TypePOS { get; set; }

        //public string TenTrungTam { get; set; }
        public int Demo { get; set; }
    }

    [Serializable]
    public class DMKhoSInfo
    {
        public int IdKho { get; set; }
        public int IdTrungTam { get; set; }
    }
}
