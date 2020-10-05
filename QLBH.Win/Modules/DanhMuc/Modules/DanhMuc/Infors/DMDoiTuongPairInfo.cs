using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMDoiTuongPairInfo
    {
        
        public int IdDoiTuong { get; set; }

        public string MaDoiTuong { get; set; }
        
        public string TenDoiTuong { get; set; }
        
        public int SuDung { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is DMDoiTuongInfo && (IdDoiTuong == ((DMDoiTuongInfo)obj).IdDoiTuong ||
                MaDoiTuong == ((DMDoiTuongInfo)obj).MaDoiTuong);
        }
    }
}
