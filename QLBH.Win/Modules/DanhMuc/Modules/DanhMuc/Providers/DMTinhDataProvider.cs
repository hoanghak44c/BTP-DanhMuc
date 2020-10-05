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

    public class DMTinhDataProvider
    {
        private static DMTinhDataProvider instance;
        public static DMTinhDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMTinhDataProvider();
                return instance;
            }   
        }

        public List<DMTinhInfor> GetListTinhInfors()
        {
            return DmTinhDAO.Instance.GetListTinhInfors();
        }

        public DMTinhInfor GetTinhThanhByText(string tinh)
        {
            return DmTinhDAO.Instance.GetTinhThanhByText(tinh);
        }

        public DMTinhInfor GetTinhThanhById(int tinh)
        {
            return DmTinhDAO.Instance.GetTinhThanhById(tinh);
        }
    }
}
