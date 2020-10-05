using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    //hah sao cai info nay lai nhieu thong tin the nhi (hoi giong DMMaLoiInfor)
    [Serializable]
    public class DMMaLoiPairInfor
    {
        public int IdMaLoi { get; set; }

        public string MaLoi { get; set; }

        public int IdLoaiItem { get; set; }

        public string TenLoi { get; set; }

        public string GhiChu { get; set; }

        public int SuDung { get; set; }

        public string TenLoaiItem { get; set; }
    }
}
