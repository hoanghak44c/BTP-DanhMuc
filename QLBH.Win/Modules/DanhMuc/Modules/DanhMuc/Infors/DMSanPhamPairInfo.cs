using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMSanPhamPairInfo
    {
        public int IdSanPham { get; set; }
        
        public string TenSanPham { get; set; }
        
        public int SuDung { get; set; }
    }
}
