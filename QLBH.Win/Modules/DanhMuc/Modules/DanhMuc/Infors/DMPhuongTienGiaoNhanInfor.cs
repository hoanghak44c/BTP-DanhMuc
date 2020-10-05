using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMPhuongTienGiaoNhanInfor
    {
        public string MaPhuongTien { get; set; }

        public string TenPhuongTien { get; set; }

        public string GhiChu { get; set; }

        public int SuDung { get; set; }
    }
}
