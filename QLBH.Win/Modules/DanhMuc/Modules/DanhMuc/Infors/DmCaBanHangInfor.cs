using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DmCaBanHangInfor
    {
        public string KyHieu { get; set; }
        public string CaBanHang { get; set; }
        public int TuGio { get; set; }
        public int TuPhut { get; set; }
        public int DenGio { get; set; }
        public int DenPhut { get; set; }
    }
}
