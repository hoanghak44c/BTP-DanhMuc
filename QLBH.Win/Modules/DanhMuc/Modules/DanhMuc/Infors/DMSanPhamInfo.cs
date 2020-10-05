using System;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMSanPhamInfo : IPagingInfo
    {
        [DefaultDisplay(false)]
        public int IdSanPham { get; set; }

        [DefaultDisplay(false)]
        public int IdCha { get; set; }

        [DefaultDisplay(false)]
        public string MaVach { get; set; }

        [CaptionColumn("Mã sản phẩm")]
        public string MaSanPham { get; set; }

        [CaptionColumn("Tên sản phẩm")]
        public string TenSanPham { get; set; }

        [DefaultDisplay(false)]
        public int IdDonViTinh { get; set; }

        [CaptionColumn("Giá nhập")]
        public int GiaNhap { get; set; }

        [CaptionColumn("Mô tả")]
        public string MoTa { get; set; }

        [CaptionColumn("Sử dụng")]
        public int SuDung { get; set; }

        [CaptionColumn("Trùng mã vạch")]
        public int TrungMaVach { get; set; }
        
        [CaptionColumn("Tên viết tắt")]
        public string TenVietTat { get; set; }

        [CaptionColumn("Chiết khấu")]
        public int ChietKhau { get; set; }

        [CaptionColumn("Bảo hành hãng")]
        public int BaoHanhHang { get; set; }

        [CaptionColumn("Bảo hành khách")]
        public int BaoHanhKhach { get; set; }
        /// <summary>
        /// IdTaxCode
        /// </summary>
        [CaptionColumn("Tỷ lệ VAT"), DefaultDisplay(false)]
        public int TyLeVAT { get; set; }
        [CaptionColumn("VAT")]
        public int GiaTriVAT { get; set; }
        [CaptionColumn("Tax Code"), DefaultDisplay(false)]
        public string TaxCode { get; set; }
        
        [CaptionColumn("Loại sản phẩm")]
        public string TenLoaiSP { get; set; }

        [CaptionColumn("Ngành")]
        public string Nganh { get; set; }

        [CaptionColumn("Loại")]
        public string Loai { get; set; }

        [CaptionColumn("Hãng"), DefaultDisplay(false)]
        public string Hang { get; set; }

        [CaptionColumn("Phụ kiện")]
        public int PhuKien { get; set; }

        [CaptionColumn("Hàng khuyến mại")]
        public int HangKhuyenMai { get; set; }

        public string Model { get; set; }

        #region Implementation of IPagingInfo

        public int RecordNumber { get; set; }

        #endregion
    }

    public interface IPagingInfo
    {
        int RecordNumber { get; set; }
    }

    [Serializable]
    public class DMSanPhamInfoEx : DMSanPhamInfo
    {
        public string MaKho { get; set; }
        public int IdKho { get; set; }
    }
}
