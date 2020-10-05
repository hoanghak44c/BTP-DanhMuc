using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DmNgheNghiepInfor
    {
        public int IdNgheNghiep { get; set; }

        public string MaNgheNghiep { get; set; }

        public string TenNgheNghiep { get; set; }

        public string GhiChu { get; set; }
    }
}
