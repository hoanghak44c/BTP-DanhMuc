using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMChucNangInfor
    {
        public int IdChucNang { get; set; }

        public string MaChucNang { get; set; }

        public string TenChucNang { get; set; }

        public string GhiChu { get; set; }

        public int SuDung { get; set; }
    }
}
