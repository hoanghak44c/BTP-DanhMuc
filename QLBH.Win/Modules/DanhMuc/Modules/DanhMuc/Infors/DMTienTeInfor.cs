using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMTienTeInfor
    {
        public int IdTienTe { get; set; }

        public string KyHieu { get; set; }

        public string TenTienTe { get; set; }

        public string GhiChu { get; set; }

        public int SuDung { get; set; }

        public float TyGia { get; set; }
    }
}
