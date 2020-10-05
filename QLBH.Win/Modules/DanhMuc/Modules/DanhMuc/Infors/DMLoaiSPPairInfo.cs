using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMLoaiSPPairInfo
    {
        public int IdLoaiSP { get; set; }

        public string TenLoaiSP { get; set; }

        public int SuDung { get; set; }
    }
}
