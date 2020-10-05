using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMHuyenInfor
    {
        public int IdHuyen { get; set; }

        public int IdTinh { get; set; }

        public string MaHuyen { get; set; }

        public string TenHuyen { get; set; }

        public string GhiChu { get; set; }
    }
}
