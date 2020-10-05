using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DmLoaiTheUuDaiInfo
    {
        public int IdUuDai { get; set; }
        
        public int IdLoaiThe { get; set; }
        
        public string DichVu { get; set; }
        
        public string UuDai { get; set; }
    }
}
