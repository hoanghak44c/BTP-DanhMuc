using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMLoaiDichVuInfor
    {
        public int IdLoaiDichVu { get; set; }

        public string MaLoaiDichVu { get; set; }

        public string TenDichVu { get; set; }

        public string GhiChu { get; set; }

        public int SuDung { get; set; }
    }
}
