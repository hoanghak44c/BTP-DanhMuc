using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMSanPhamBriefInfo
    {
        public string NganhHang { get; set; }

        public string LoaiSanPham { get; set; }

        public string TenLoaiSP { get; set; }

        public int IdSanPham { get; set; }

        public string MaSanPham { get; set; }

        public string TenSanPham { get; set; }

        public string TenDonViTinh { get; set; }

        public int SuDung { get; set; }

        public int TrungMaVach { get; set; }

        public string TenVietTat { get; set; }

        public int ChietKhau { get; set; }

        public double TyLeVAT { get; set; }

        public int TonKho { get; set; }

        public int HangKhuyenMai { get; set; }
    }
}
