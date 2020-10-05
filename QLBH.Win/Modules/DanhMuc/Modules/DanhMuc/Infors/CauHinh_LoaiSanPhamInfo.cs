using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class CauHinh_LoaiSanPhamInfo
    {
        public int IdCauHinh { get; set; }

        public int IdSanPham { get; set; }

        public string MaCauHinh { get; set; }

        public string TenCauHinh { get; set; }

        public string GhiChu { get; set; }

        public int SuDung { get; set; }

        public string TenLoaiSp { get; set; }
    }
}
