using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMDonViTinhLoadInfor
    {
        public int IdDonViTinh { get; set; }

        public string TenDonViTinh { get; set; }

        public int SuDung { get; set; }
    }
}
