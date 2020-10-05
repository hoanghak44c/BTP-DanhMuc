using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DoiTuong_DiaChiInfo
    {
        public int IdDiaChi { get; set; }
        
        public int IdDoiTuong { get; set; }
        
        public string SiteNumber { get; set; }
        
        public string DiaChi { get; set; }
        
        public string MaVung { get; set; }
    }
}
