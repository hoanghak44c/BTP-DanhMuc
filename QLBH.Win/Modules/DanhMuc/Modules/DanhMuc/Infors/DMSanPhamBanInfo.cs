using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMSanPhamBanInfo
    {
        public int IdSanPham { get; set; }
       
        public string MaSanPham { get; set; }

        public string TenSanPham { get; set; }
                        
        public string TenDonViTinh { get; set; }
        
        public double DonGiaChuaVAT { get; set; }
        
        public double TyLeChietKhau { get; set; }
        
        public double TienChietKhau { get; set; }
        
        public double TyLeVAT { get; set; }
        
        public double TienVAT { get; set; }

        public double DonGiaCoVAT { get; set; }

        public double TyLeThuong { get; set; }
        
        public double ThuongNong { get; set; }
    }
}
