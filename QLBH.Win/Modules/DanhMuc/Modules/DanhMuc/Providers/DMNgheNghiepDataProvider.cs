using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;

// <Remarks>
// Tạo DMBieuMauThueProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 09/03/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.DanhMuc.Providers
{

    public class DMNgheNghiepDataProvider
    {
        private static DMNgheNghiepDataProvider instance;
        public static DMNgheNghiepDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMNgheNghiepDataProvider();
                return instance;
            }   
        }

        public List<DmNgheNghiepInfor> GetListNgheNghiepInfors()
        {
            return DmNgheNghiepDAO.Instance.GetListNgheNghiepInfors();
        }
    }
}
