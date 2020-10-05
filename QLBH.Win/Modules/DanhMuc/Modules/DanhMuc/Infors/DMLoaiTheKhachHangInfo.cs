using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMLoaiTheKhachHangInfo
    {
        public int IdLoaiThe { get; set; }
        
        public string MaThe { get; set; }
        
        public string TenThe { get; set; }
        
        public string GhiChu { get; set; }
        
        public int ThoiGianHieuLuc { get; set; }
       
        public int DoUuTien { get; set; }
        
        public int BaoLuuDiem { get; set; }
        
        public int SuDung { get; set; }
        
        public int DK_GT_LanDau { get; set; }
        
        public int DK_GT_TichLuy_Tu { get; set; }
        
        public int DK_GT_TichLuy_Den { get; set; }
        
        public string DK_SP_KemTheo { get; set; }
        
        public int IsTangQuaSN { get; set; }
        
        public int IsBHVang { get; set; }
        
        public int IsUpdateSPNew { get; set; }
        
        public int IsJointCourse { get; set; }
        
        public int IsSupport { get; set; }
    }
}
