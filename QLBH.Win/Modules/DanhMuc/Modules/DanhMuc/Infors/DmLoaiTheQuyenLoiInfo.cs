using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DmLoaiTheQuyenLoiInfo
    {
        public int IdQuyenLoi { get; set; }
        
        public int IdLoaiThe { get; set; }
        
        public int IdSanPham { get; set; }
        
        public int TyLeGiam { get; set; }
       
        public string GhiChu { get; set; }
    }
}
