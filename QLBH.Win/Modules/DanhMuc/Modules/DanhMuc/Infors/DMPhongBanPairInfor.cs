using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMPhongBanPairInfor
    {
        public int IdPhongBan { get; set; }

        public string TenPhongBan { get; set; }

        public int SuDung { get; set; }
    }
}
