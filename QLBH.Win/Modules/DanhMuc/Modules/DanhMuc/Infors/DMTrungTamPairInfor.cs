using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMTrungTamPairInfor
    {
        public int IdTrungTam { get; set; }

        public string MaTrungTam { get; set; }

        public string TenTrungTam { get; set; }

        public int SuDung { get; set; }
    }
}
