using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMVungMienKhachInfor
    {
        public string MaVung { get; set; }

        public string TenVungMien { get; set; }

        public double HeSo { get; set; }

        public string GhiChu { get; set; }

        public int SuDung { get; set; }
    }
}
