using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMTinhInfor
    {
        public int IdTinh { get; set; }

        public string MaTinh { get; set; }

        public string TenTinh { get; set; }

        public string GhiChu { get; set; }
    }
}
