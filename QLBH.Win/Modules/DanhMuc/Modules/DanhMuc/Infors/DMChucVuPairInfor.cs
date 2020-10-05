using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
   public class DMChucVuPairInfor
    {
        public int IdChucVu { get; set; }

        public string TenChucVu { get; set; }

        public int SuDung { get; set; }
    }
}
