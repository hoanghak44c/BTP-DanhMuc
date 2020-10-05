using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMLoaiTheKhachHangLoadInfo
    {
        public int IdLoaiThe { get; set; }
        
        public string MaThe { get; set; }
        
        public string TenThe { get; set; }
        
        public string GhiChu { get; set; }
        
        public int SuDung { get; set; }
    }
}
