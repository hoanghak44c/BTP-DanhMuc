using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMOrderTypePairInfor
    {
        public int IdOrderType { get; set; }

        public string Name { get; set; }

        public int SuDung { get; set; }

        public string OrderType { get; set; }
        
    }
}
